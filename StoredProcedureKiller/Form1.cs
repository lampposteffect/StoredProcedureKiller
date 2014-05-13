using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoredProcedureKiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnKillIt_Click(object sender, EventArgs e)
        {
            if (txtSQL.Text.Length < 1)
                return;

            var theSQLs = txtSQL.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            var theCodes = new List<string>();
            if (rdoVisualBasic.Checked)
            {
                theCodes.Add("Dim sql As String = " + convertToVB(theSQLs[0]));
                for (int i = 1; i < theSQLs.Length - 2; i++)
                    theCodes.Add(convertToVB(theSQLs[i]));
                theCodes.Add(@"""" + theSQLs[theSQLs.Length - 1] + @"""");
            }
            else
            {
                theCodes.Add("var sql = " + convertToSeeSharp(theSQLs[0]));
                for (int i = 1; i < theSQLs.Length - 2; i++)
                    theCodes.Add(convertToSeeSharp(theSQLs[i]));
                theCodes.Add(@"""" + theSQLs[theSQLs.Length - 1] + @""";");
            }

            txtCode.Text = string.Join("\n", theCodes.ToArray());
            Clipboard.SetText(txtCode.Text);
        }

        private string convertToVB(string sql)
        {
            return string.Format("{0}{1}{0} & Environment.NewLine & _", @"""", sql);
        }

        private string convertToSeeSharp(string sql)
        {
            return string.Format("{0}{1}{0} + Environment.NewLine +", @"""", sql);
        }
    }
}
