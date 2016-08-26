using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntonBogunM16_Lab1_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Columns.Add("Semester", 80);
            this.listView1.Columns.Add("1", 70);
            this.listView1.Columns.Add("2", 70);
            this.listView1.Columns.Add("3", 70);
            this.listView1.Columns.Add("4", 70);
            this.listView1.Columns.Add("5", 70);
            this.listView1.Columns.Add("6", 70);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.listView1.Items.Clear();
            if (this.treeView1.SelectedNode.Text == "SETechnician")
            {

                listView1.Items.Add(new ListViewItem(new[] { "SEM1", "COMM171", "COMP100", "COMP120", "COMP213", "GNED219", "MATH175" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM2", "COMP122", "COMP123", "COMP125", "COMP225", "GNED301", "MATH185" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM3", "COMP214", "COMP228", "COMP229", "COMP246", "GNED500", "ENGL253" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM4", "COMP212", "COMP231", "COMP311", "COMP316", "EMPS101", "GNED" }));

            }
            else if (this.treeView1.SelectedNode.Text == "SET")
            {
                listView1.Items.Add(new ListViewItem(new[] { "SEM1", "COMM-170", "COMP-100", "COMP-120", "COMP-213", "GNED-219", "MATH-175" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM2", "COMP-122", "COMP-123", "COMP-125", "COMP-225", "COMP-301", "MATH-185" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM3", "COMP-214", "COMP-228", "COMP-229", "COMP-246", "ENGL-253", "GNED-500" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM4", "CNET-124", "CNET-329", "COMP-212", "COMP-311", "ELECT  ", "MATH-210" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM5", "COMP-231", "COMP-303", "COMP-304", "COMP-306", "COMP-307", "COMP-309" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM6", "CNET-307", "COMP-308", "COMP-313", "COMP-321", "ELECT 2", "EMPS-102" }));

            }
            else if (this.treeView1.SelectedNode.Text == "SET-IG")
            {
                listView1.Items.Add(new ListViewItem(new[] { "SEM1", "COMM-170", "COMP-100", "COMP-120", "COMP-213", "GNED-219", "MATH-175" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM2", "COMP-122", "COMP-123", "COMP-125", "COMP-225", "COMP-301", "COMP-391" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM3", "COMP-214", "COMP-229", "COMP-246", "COMP-305", "GNED-500", "MATH-185" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM4", "COMP-212", "COMP-228", "COMP-311", "ENGL-253", "GNED    ", "MATH-210" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM5", "CNET-124", "CNET-307", "COMP-231", "COMP-304", "COMP-394", "COMP-396" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM6", "CNET-329", "COMP-308", "COMP-313", "COMP-392", "COMP-395", "COMP-397" }));


            }
            else if (this.treeView1.SelectedNode.Text == "HIT")
            {
                listView1.Items.Add(new ListViewItem(new[] { "SEM1", "COMM-170", "COMP-100", "COMP-120", "COMP-213", "GNED-219", "MATH-175" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM2", "COMP-122", "COMP-123", "COMP-125", "COMP-225", "COMP-301", "COMP-380" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM3", "COMP-214", "COMP-229", "COMP-246", "COMP-381", "GNED-500", "MATH-185" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM4", "COMP-212", "COMP-228", "COMP-311", "ENGL-253", "GNED    ", "MATH-210" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM5", "COMP-231", "COMP-304", "COMP-309", "COMP-383", "COMP-384", "COMP-387" }));
                listView1.Items.Add(new ListViewItem(new[] { "SEM6", "CNET-124", "CNET-307", "CNET-329", "COMP-313", "COMP-321", "COMP-382" }));
            }
        }
    }
}






