using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windows_Explorer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void menu_FileExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Clipboard.Clear();
			foreach (string drive in System.IO.Directory.GetLogicalDrives())
			{
				DriveInfo di = new DriveInfo(drive);
				int driveImage;

				switch (di.DriveType)
				{
					case DriveType.CDRom:
						driveImage = 3;
						break;
					case DriveType.Network:
						driveImage = 6;
						break;
					case DriveType.NoRootDirectory:
						driveImage = 8;
						break;
					case DriveType.Unknown:
						driveImage = 8;
						break;
					default:
						driveImage = 2;
						break;
				}

				TreeNode node = new TreeNode(drive.Substring(0, 3), driveImage, driveImage);
				node.Tag = drive;

				if (di.IsReady == true)
					node.Nodes.Add("...");

				tView.Nodes.Add(node);

			}
		}

		static bool checkView = false;

		private string GetPathFromRoot(TreeNode node)
		{
			return GetPathFromRoot(node.Parent) + "\\" + node.Text;
		}


		private void tView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.Nodes.Count > 0)
			{
				if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
				{
					e.Node.Nodes.Clear();

					string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

					DirectoryInfo rootDir = new DirectoryInfo(e.Node.Tag.ToString());

					foreach (string dir in dirs)
					{
						DirectoryInfo di = new DirectoryInfo(dir);
						TreeNode node = new TreeNode(di.Name, 0, 1);

						try
						{
							node.Tag = dir;

							if (di.GetDirectories().Count() > 0)
								node.Nodes.Add(null, "...", 0, 0);
						}
						catch (UnauthorizedAccessException)
						{
							node.ImageIndex = 12;
							node.SelectedImageIndex = 12;
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "DirectoryLister",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						finally
						{
							e.Node.Nodes.Add(node);
						}
					}
				}
			}
		}

		private void menu_FileRename_Click(object sender, EventArgs e)
		{
			if (lv_View.SelectedItems.Count > 0)
			{
				lv_View.SelectedItems[0].BeginEdit();
			}
		}

		private void tView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (checkView)
			{
				tView.SelectedNode.Expand();
			}
			else
			{
				tView.SelectedNode.Collapse();
			}

			lv_View.Items.Clear();

			TreeNode currentNode = e.Node;
			string fullPath = currentNode.FullPath;

			try
			{
				string[] dirs = Directory.GetDirectories(fullPath);
				foreach (string dir in dirs)
				{
					DirectoryInfo di = new DirectoryInfo(dir);
					ListViewItem item = new ListViewItem(Path.GetFileName(dir), 1);
					item.SubItems.Add(di.CreationTime.ToShortDateString());
					item.Tag = currentNode;
					lv_View.Items.Add(item);
				}

				string[] files = Directory.GetFiles(fullPath);
				foreach (string file in files)
				{
					FileInfo fi = new FileInfo(file);
					ListViewItem item = new ListViewItem(Path.GetFileName(file), 2);
					item.SubItems.Add(fi.CreationTime.ToShortDateString());
					item.SubItems.Add(fi.Extension);
					string size = FileSizeFormatter.FormatSize(fi.Length);
					item.Tag = currentNode;
					item.SubItems.Add(size);
					lv_View.Items.Add(item);
				}
			}
			catch (UnauthorizedAccessException ex)
			{
				MessageBox.Show($"Access to {fullPath} is denied.");
			}

		}

		private void view_LargeIcon_Click(object sender, EventArgs e)
		{
			lv_View.View = View.LargeIcon;
			ImageList iList = new ImageList();
			iList.ImageSize = new Size(64, 64);
			iList.ColorDepth = ColorDepth.Depth32Bit;
			lv_View.LargeImageList = iList;
		}

		private void view_SmallIcon_Click(object sender, EventArgs e)
		{
			lv_View.View = View.SmallIcon;
			ImageList iList = new ImageList();
			iList.ImageSize = new Size(16, 16);
			iList.ColorDepth = ColorDepth.Depth32Bit;
			lv_View.SmallImageList = iList;

		}

		private void view_ListIcon_Click(object sender, EventArgs e)
		{
			lv_View.View = View.List;
			ImageList iList = new ImageList();
			iList.ImageSize = new Size(16, 16);
			iList.ColorDepth = ColorDepth.Depth32Bit;
			lv_View.SmallImageList = iList;

		}

		private void view_Details_Click(object sender, EventArgs e)
		{
			lv_View.View = View.Details;
		}

		private void view_List_Click(object sender, EventArgs e)
		{
			lv_View.View = View.List;
		}

		private void tsbtn_Up_Click(object sender, EventArgs e)
		{
			if (tView.SelectedNode.Parent != null)
			{
				tView.SelectedNode = tView.SelectedNode.Parent;
			}
		}

		private void tsbtn_Refresh_Click(object sender, EventArgs e)
		{
			tView.Refresh();
			lv_View.Refresh();
		}

		private void lv_View_AfterLabelEdit(object sender, LabelEditEventArgs e)
		{
			if (e.Label != null)
			{
				string newName = e.Label;
				try
				{
					var item = lv_View.SelectedItems[0];
					TreeNode node = (TreeNode)item.Tag;

					string path = node.FullPath + @"\" + item.Text;

					if (Directory.Exists(path))
					{
						DirectoryInfo di = new DirectoryInfo(path);
						di.MoveTo(Path.Combine(di.Parent.FullName, newName));

					}
					else if (File.Exists(path))
					{
						FileInfo fi = new FileInfo(path);
						fi.MoveTo(Path.Combine(fi.Directory.FullName, newName));
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void help_About_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Copyright by Ho Van Phuong", "Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void allSubfolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tView.SelectedNode.Expand();
			checkView = true;
		}

		private void onlyFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tView.SelectedNode.Collapse();
			checkView = false;
		}

		private void tsbtn_Delete_Click(object sender, EventArgs e)
		{
			var item = lv_View.SelectedItems[0];
			TreeNode node = (TreeNode)item.Tag;
			string path = node.FullPath + @"\" + item.Text;

			if (Directory.Exists(path))
			{
				Directory.Delete(path);
			}
			else if (File.Exists(path))
			{
				File.Delete(path);
			}
			item.Remove();
			lv_View.Refresh();
		}

		public bool IsClipboardCutOperation()
		{
			IDataObject clipboardData = Clipboard.GetDataObject();

			if (clipboardData.GetDataPresent(DataFormats.FileDrop))
			{
				MemoryStream dropEffect = clipboardData.GetData("Preferred DropEffect") as MemoryStream;

				if (dropEffect != null)
				{
					byte[] moveEffect = new byte[4];
					dropEffect.Read(moveEffect, 0, moveEffect.Length);

					int dropEffectValue = BitConverter.ToInt32(moveEffect, 0);

					if (dropEffectValue == 2)
					{
						return true;
					}
				}
			}

			return false;
		}

		private void tsbtn_Copy_Click(object sender, EventArgs e)
		{
			if (lv_View.SelectedItems.Count > 0)
			{
				var item = lv_View.SelectedItems[0];
				TreeNode node = (TreeNode)item.Tag;
				string path = node.FullPath + @"\" + item.Text;

				System.Collections.Specialized.StringCollection files = new System.Collections.Specialized.StringCollection();

				files.Add(path);

				Clipboard.SetFileDropList(files);
				menu_EditPaste.Enabled = true;
			}
		}

		static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
		{
			var dir = new DirectoryInfo(sourceDir);

			if (!dir.Exists)
				throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

			DirectoryInfo[] dirs = dir.GetDirectories();

			Directory.CreateDirectory(destinationDir);

			foreach (FileInfo file in dir.GetFiles())
			{
				string targetFilePath = Path.Combine(destinationDir, file.Name);
				file.CopyTo(targetFilePath);
			}

			if (recursive)
			{
				foreach (DirectoryInfo subDir in dirs)
				{
					string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
					CopyDirectory(subDir.FullName, newDestinationDir, true);
				}
			}
		}

		private void tsbtn_Paste_Click(object sender, EventArgs e)
		{
			if (!IsClipboardCutOperation())
			{
				if (Clipboard.ContainsFileDropList())
				{
					System.Collections.Specialized.StringCollection files = Clipboard.GetFileDropList();

					TreeNode node = tView.SelectedNode;

					string directoryPath = node.FullPath;

					foreach (string file in files)
					{
						if (File.Exists(file))
						{
							string fileName = System.IO.Path.GetFileName(file);

							string newPath = System.IO.Path.Combine(directoryPath, fileName);

							File.Copy(file, newPath, true);
						}
						else if (Directory.Exists(file))
						{
							string[] data = file.Split('\\').ToArray();
							string destinationPath = node.FullPath + "\\" + data[data.Length - 1];
							CopyDirectory(file, destinationPath, true);
						}
					}
				}
			}
			else
			{
				System.Collections.Specialized.StringCollection files = Clipboard.GetFileDropList();

				foreach (string file in files)
				{
					string[] data = file.Split('\\').ToArray();
					TreeNode node = tView.SelectedNode;
					string destinationPath = node.FullPath + "\\" + data[data.Length - 1];
					if (File.Exists(file))
					{
						if (File.Exists(destinationPath))
						{
							File.Delete(destinationPath);
						}
						File.Move(file, destinationPath);
					}
					else if (Directory.Exists(file))
					{
						if (destinationPath.StartsWith(file))
						{
							string newPath = destinationPath + Path.GetFileName(file);
							Directory.Move(file, newPath);
							Directory.Delete(destinationPath);
							Directory.Move(newPath, newPath.Remove(newPath.Length - Path.GetFileName(file).Length));
						}
						else
						{
							Directory.Move(file, destinationPath);
						}
					}
				}
			}
			Clipboard.Clear();
			menu_EditPaste.Enabled = false;
			tView.Refresh();
			lv_View.Refresh();
		}

		private void tsbtn_Cut_Click(object sender, EventArgs e)
		{
			if (lv_View.SelectedItems.Count > 0)
			{
				var item = lv_View.SelectedItems[0];
				TreeNode node = (TreeNode)item.Tag;
				string path = node.FullPath + @"\" + item.Text;

				StringCollection paths = new StringCollection();
				paths.Add(path);

				byte[] moveEffect = new byte[] { 2, 0, 0, 0 };
				MemoryStream dropEffect = new MemoryStream();
				dropEffect.Write(moveEffect, 0, moveEffect.Length);

				DataObject data = new DataObject();
				data.SetFileDropList(paths);
				data.SetData("Preferred DropEffect", dropEffect);

				Clipboard.Clear();
				Clipboard.SetDataObject(data, true);

				lv_View.Refresh();
				menu_EditPaste.Enabled = true;
			}
		}

		private void menu_FileDelete_Click(object sender, EventArgs e)
		{
			tsbtn_Delete.PerformClick();
		}

		private void menu_EditCopy_Click(object sender, EventArgs e)
		{
			tsbtn_Copy.PerformClick();
		}

		private void menu_EditCut_Click(object sender, EventArgs e)
		{
			tsbtn_Cut.PerformClick();
		}

		private void menu_EditPaste_Click(object sender, EventArgs e)
		{
			if (menu_EditPaste.Enabled == true)
			{
				tsbtn_Paste.PerformClick();
			}
		}
	}

	// FileFormat

	public static class FileSizeFormatter
	{
		static readonly string[] suffixes =
		{ "Bytes", "KB", "MB", "GB", "TB", "PB" };
		public static string FormatSize(Int64 bytes)
		{
			int counter = 0;
			decimal number = (decimal)bytes;
			while (Math.Round(number / 1024) >= 1)
			{
				number = number / 1024;
				counter++;
			}
			return string.Format("{0:n0} {1}", number, suffixes[counter]);
		}
	}

}
