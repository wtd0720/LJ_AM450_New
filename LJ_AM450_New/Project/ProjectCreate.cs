using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJ_AM450_New
{
    public partial class ProjectCreate : Form
    {
        MyProject mp;
        MainForm mf;
        public ProjectCreate(MyProject _mp)
        {
            mp = _mp;
            InitializeComponent();
        }

        private void InputModelButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = GetFileImportFilter();
                string[] files = GetFileNamesToImport(filter);
                if (files == null)
                {
                    return;
                }
                ModelLabel.Text = files[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
            }
        }

        private void DeleteModelButton_Click(object sender, EventArgs e)
        {
            ModelLabel.Text = "";
        }

        private void InputSupButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = GetFileImportFilter();
                string[] files = GetFileNamesToImport(filter);
                if (files == null)
                {
                    return;
                }
                SupLabel.Text = files[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
            }
        }

        private void DeleteSupButton_Click(object sender, EventArgs e)
        {
            SupLabel.Text = "";
        }

        private void InputParaButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = GetParaFilter();
                string[] files = GetFileNamesToImport(filter);
                if (files == null)
                {
                    return;
                }
                ParaLabel.Text = files[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
            }
        }

        private void DeleteParaButton_Click(object sender, EventArgs e)
        {
            ParaLabel.Text = "";
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            mp.Name = ProjectName.Text;
            mp._modelfile = ModelLabel.Text;
            mp._supportfile = SupLabel.Text;
            mp.para = new ParaAll(ParaLabel.Text);
            mf.LoadData(mp);
            this.Dispose();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string GetFileImportFilter()
        {
            string filter = "Stereolitography files|*.slc";
            return filter;
        }
        private string GetParaFilter()
        {
            string filter = "参数文件|*.ljpm";
            return filter;
        }

        public string[] GetFileNamesToImport(string filter)
        {
            string[] fileNames = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = filter;
                openFileDialog.FileName = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileNames = openFileDialog.FileNames;
                }
            }
            return fileNames;
        }

        private void ProjectCreat_Load(object sender, EventArgs e)
        {
            mf = (MainForm)this.Owner;
        }
    }
    
}
