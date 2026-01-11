using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNotice3._0.Classes
{
    internal class AppConstant
    {
        public static string strMsgBoxCaption = "Notice generation utility";
        public static string strSelect = "--Select--";
        public static string strSave = "Record added successfully.";
        public static string strEdit = "Record modified successfully.";
        public static string strDelete = "Record(s) deleted successfully.";
        public static string strSingleDelete = "Do you want to delete the record?";
        public static string strMultiDelete = "You have selected multiple records for deletion, Do you want to proceed?";
        public static string strNumericValidation = "Please enter valid number for ";
        public static string strBlankValidation = "Please do not left blank : ";
        public static string strSelectValidation = "Please select any one of : ";
        public static string strZipCodeValidation = "Please enter valid zipcode ";
        public static string strMsgParentExit = "Are you sure to exit? ";

        internal ToolTip SetBaloonToolTip(
          Control Control,
          string ToolTipTitle,
          string ToolTipString,
          ToolTipIcon ToolTipIcon,
          Color BackColor)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.RemoveAll();
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = ToolTipTitle;
            toolTip.ShowAlways = true;
            toolTip.BackColor = BackColor;
            toolTip.SetToolTip(Control, ToolTipString);
            toolTip.UseAnimation = false;
            toolTip.UseFading = false;
            toolTip.Active = true;
            return toolTip;
        }

        protected internal void Export(DataGridView grdView)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                string str1 = "";
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = ".csv";
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                int num1 = (int)saveFileDialog.ShowDialog();
                string fileName = saveFileDialog.FileName;
                if (fileName == "")
                    return;
                StreamWriter streamWriter = new StreamWriter(fileName);
                for (int index = 0; index < grdView.Columns.Count; ++index)
                {
                    if (str1 == "")
                    {
                        if (grdView.Columns[index].HeaderText == "" || grdView.Columns[index].HeaderText == null)
                            str1 = grdView.Columns[index].Name.ToString().Trim();
                        else if (grdView.Columns[index].HeaderText != "")
                            str1 = grdView.Columns[index].HeaderText.ToString().Trim();
                    }
                    else if (grdView.Columns[index].HeaderText == "" || grdView.Columns[index].HeaderText == null)
                        str1 = str1 + ", " + grdView.Columns[index].Name.ToString().Trim();
                    else if (grdView.Columns[index].HeaderText != "")
                        str1 = str1 + ", " + grdView.Columns[index].HeaderText.ToString().Trim();
                }
                streamWriter.WriteLine(str1);
                for (int index1 = 0; index1 < grdView.Rows.Count; ++index1)
                {
                    string str2 = "";
                    for (int index2 = 0; index2 < grdView.Columns.Count; ++index2)
                        str2 = !(str2 == "") ? str2 + ", " + grdView.Rows[index1].Cells[index2].Value.ToString().Trim() : grdView.Rows[index1].Cells[index2].Value.ToString().Trim();
                    streamWriter.WriteLine(str2);
                }
                streamWriter.Dispose();
                streamWriter.Close();
                int num2 = (int)MessageBox.Show("File has been exported successfully.", AppConstant.strMsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, AppConstant.strMsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        protected internal DataGridView FilterDGV(
          DataGridView grdView,
          string strSearchText)
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = grdView.DataSource;
                string str = "";
                foreach (DataGridViewColumn column in (BaseCollection)grdView.Columns)
                {
                    if (column.Name != "Alt_Date" && column.Visible)
                    {
                        if (str == "")
                        {
                            if (column.ValueType.Name == "Int32" || column.ValueType.Name == "Int16" || column.ValueType.Name == "Byte" || column.ValueType.Name == "Boolean")
                            {
                                if (strSearchText.Trim() != "" && IsNumeric(strSearchText.Trim().ToString()))
                                    str = column.Name + " = " + strSearchText.Trim().ToString() + "";
                            }
                            else if (column.ValueType.Name == "DateTime")
                            {
                                if (this.IsDate(strSearchText.Trim()))
                                    str = column.Name + " = '" + strSearchText.Trim().ToString() + "'";
                            }
                            else if (column.ValueType.Name != "DateTime" && strSearchText.Trim() != "")
                                str = column.Name + " like '*" + strSearchText.Trim().ToString() + "*'";
                        }
                        else if (column.ValueType.Name == "Int32" || column.ValueType.Name == "Int16" || column.ValueType.Name == "Byte" || column.ValueType.Name == "Boolean")
                        {
                            if (strSearchText.Trim() != "" && IsNumeric(strSearchText.Trim().ToString()))
                                str = str + " and " + column.Name + " = " + strSearchText.Trim().ToString() + "";
                        }
                        else if (column.ValueType.Name == "DateTime")
                        {
                            if (this.IsDate(strSearchText.Trim()))
                                str = str + " or " + column.Name + " = '" + strSearchText.Trim().ToString() + "'";
                        }
                        else if (column.ValueType.Name != "DateTime" && strSearchText.Trim() != "")
                            str = str + " or " + column.Name + " like '*" + strSearchText.Trim().ToString() + "*'";
                    }
                }
                if (str != "")
                {
                    try
                    {
                        bindingSource.Filter = str;
                    }
                    catch
                    {
                        bindingSource.RemoveFilter();
                    }
                }
                else
                    bindingSource.RemoveFilter();
                grdView.DataSource = (object)bindingSource;
                return grdView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected internal DataGridView FilterDGVLL(
          DataGridView grdView,
          string strSearchText)
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = grdView.DataSource;
                string str = "";
                foreach (DataGridViewColumn column in (BaseCollection)grdView.Columns)
                {
                    if (column.Name != "Alt_Date" && column.Visible)
                    {
                        if (str == "")
                        {
                            if (column.ValueType.Name == "Int32")
                            {
                                if (strSearchText.Trim() != "" && IsNumeric(strSearchText.Trim().ToString()))
                                    str = column.Name + " = " + strSearchText.Trim().ToString() + "";
                            }
                            else if (strSearchText.Trim() != "")
                                str = column.Name + " like '" + strSearchText.Trim().ToString() + "%'";
                        }
                        else if (column.ValueType.Name == "Int32")
                        {
                            if (strSearchText.Trim() != "" && IsNumeric(strSearchText.Trim().ToString()))
                                str = str + " and " + column.Name + " = " + strSearchText.Trim().ToString() + "";
                        }
                        else if (strSearchText.Trim() != "")
                            str = str + " or " + column.Name + " like '" + strSearchText.Trim().ToString() + "%'";
                    }
                }
                if (str != "")
                    bindingSource.Filter = str;
                else
                    bindingSource.RemoveFilter();
                grdView.DataSource = (object)bindingSource;
                return grdView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected internal void SetCenterChildForm(
          int iMdiWidth,
          int iMdiHeight,
          string strMdiChildName,
          int iMdiChildWidth,
          int iMdiChildHeight,
          int iSideBarWidth)
        {
            int num1 = (iMdiWidth - iSideBarWidth - iMdiChildWidth) / 2;
            int num2 = (iMdiHeight - iMdiChildHeight) / 2;
            Form form = new Form();
            this.GetObjectByName(strMdiChildName).Left = num1;
        }

        protected internal Form GetObjectByName(string objFrmName) => new Form();

        public bool IsNumeric(string s)
        {
            try
            {
                int.Parse(s);
            }
            catch
            {
                return false;
            }
            return true;
        }

        protected internal bool IsDate(string s)
        {
            bool flag;
            try
            {
                Convert.ToDateTime(s);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }
    }
}
