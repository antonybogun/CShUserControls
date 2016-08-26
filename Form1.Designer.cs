using System.Windows.Forms;

namespace AntonBogunM16_Lab1_Ex2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("SETechnician");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("SET");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("SET-IG");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("HIT");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("EET");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("BMET");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ICET", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("School of Engineering Technology and Applied Science", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Centennial College", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "SETechnician";
            treeNode2.Name = "Node5";
            treeNode2.Text = "SET";
            treeNode3.Name = "Node6";
            treeNode3.Text = "SET-IG";
            treeNode4.Name = "Node7";
            treeNode4.Text = "HIT";
            treeNode5.Name = "Node8";
            treeNode5.Text = "EET";
            treeNode6.Name = "Node10";
            treeNode6.Text = "BMET";
            treeNode7.Name = "ICET";
            treeNode7.Text = "ICET";
            treeNode8.Name = "School of Engineering Technology and Applied Science";
            treeNode8.Text = "School of Engineering Technology and Applied Science";
            treeNode9.Name = "Centennial College";
            treeNode9.Text = "Centennial College";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(319, 237);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(337, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(521, 237);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 261);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.MaximumSize = new System.Drawing.Size(886, 300);
            this.MinimumSize = new System.Drawing.Size(886, 300);
            this.Name = "Form1";
            this.Text = "Course Outline";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
    }
}

