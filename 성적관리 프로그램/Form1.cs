using System;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 성적관리프로그램2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lview_member.Items.Clear();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ClearInputControl()
        {
            INPUT_NAME.Text = string.Empty;
            INPUT_NUMBER.Text = string.Empty;
            INPUT_GRADE1.Text = string.Empty;
            INPUT_GRADE2.Text = string.Empty;
            INPUT_GRADE3.Text = string.Empty;
            
        }


        private void Button_modify_Click(object sender, EventArgs e)

        {

            if (lview_member.SelectedIndices.Count == 0)

            {
                MessageBox.Show("수정할 위치를 선택해 주세요");
                return;
            }

            try
            {
                int CPlus = int.Parse(INPUT_NUMBER.Text);
                int CShap1 = int.Parse(INPUT_GRADE1.Text);
                int CShap2 = int.Parse(INPUT_GRADE2.Text);
                int CShap3 = int.Parse(INPUT_GRADE3.Text);
                int Total = CShap1 + CShap2 + CShap3;
                float Average = Total / 3.0f;


                lview_member.SelectedItems[0].SubItems[1].Text = INPUT_NAME.Text;

                lview_member.SelectedItems[0].SubItems[2].Text = INPUT_NUMBER.Text;

                lview_member.SelectedItems[0].SubItems[3].Text = INPUT_GRADE1.Text;

                lview_member.SelectedItems[0].SubItems[4].Text = INPUT_GRADE2.Text;

                lview_member.SelectedItems[0].SubItems[5].Text = INPUT_GRADE3.Text;

                lview_member.SelectedItems[0].SubItems[6].Text = Total.ToString();

                lview_member.SelectedItems[0].SubItems[7].Text = Average.ToString();



                INPUT_NAME.Clear();

                INPUT_NUMBER.Clear();

                INPUT_GRADE1.Clear();

                INPUT_GRADE2.Clear();

                INPUT_GRADE3.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("수정할 내용을 입력해주세요");
            }

        }





        private void button_search_Click2(object sender, EventArgs e)
        {
            string name = SEARCH_NAME.Text;
            string number = SEARCH_NUMBER.Text;

            for (int i = 0; i < lview_member.Items.Count; i++)
            {
                if (lview_member.Items[i].SubItems[2].Text == number && lview_member.Items[i].SubItems[1].Text == name)
                {
                    INPUT_NAME.Text = lview_member.Items[i].SubItems[1].Text;
                    INPUT_NUMBER.Text = lview_member.Items[i].SubItems[2].Text;
                    INPUT_GRADE1.Text = lview_member.Items[i].SubItems[3].Text;
                    INPUT_GRADE2.Text = lview_member.Items[i].SubItems[4].Text;
                    INPUT_GRADE3.Text = lview_member.Items[i].SubItems[5].Text;
                    return;
                }
            }
        }

        
       

        private void button_INPUT_Click(object sender, EventArgs e)
        {

            string N;
            double g1, g2, g3, res, avg;
            string R, A;

            string name = INPUT_NAME.Text;
            string number = INPUT_NUMBER.Text;
            string grade1 = INPUT_GRADE1.Text;
            string grade2 = INPUT_GRADE2.Text;
            string grade3 = INPUT_GRADE3.Text;
            
            try
            {
                N = Convert.ToString(lview_member.Items.Count + 1);
                g1 = Convert.ToDouble(grade1);
                g2 = Convert.ToDouble(grade2);
                g3 = Convert.ToDouble(grade3);
                res = g1 + g2 + g3;
                avg = res / 3;
                R = Convert.ToString(res);
                A = Convert.ToString(avg);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            for (int i = 0; i < lview_member.Items.Count; i++)
            {
                if (lview_member.Items[i].SubItems[2].Text == number)
                {
                    MessageBox.Show($"이미 {i+1}번째에 중복된 학번입니다.");
                    return;
                }
            }

            string[] strs = new string[] { N, name, number, grade1, grade2, grade3, R, A.ToString() };
            ListViewItem lvi = new ListViewItem(strs);
            lview_member.Items.Add(lvi);
            ClearInputControl();


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void CLEAR_Click(object sendar, EventArgs e)
        {
            lview_member.Items.Clear();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 항목이 삭제 됩니다.\r계속 하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lview_member.SelectedItems.Count > 0)
                {
                    int index = lview_member.FocusedItem.Index;
                    lview_member.Items.RemoveAt(index);

                    for(int i = 0; i < lview_member.Items.Count; i++)
                    {

                        lview_member.Items[i].SubItems[0].Text = Convert.ToString(i + 1);
                    }
                }
                else
                {
                    MessageBox.Show("선택된 항목이 없습니다.");
                }
            }

        }
        private void button_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        protected void button_FILESAVE_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt File|*.txt";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:

                        for (int i = 0; i < lview_member.Items.Count; i++)
                        {
                            string sTmp = "";
                            for (int j = 0; j < lview_member.Items[i].SubItems.Count; j++)
                                sTmp += lview_member.Items[i].SubItems[j].Text + ", ";
                            sTmp += "\n";
                            Byte[] Bytes = Encoding.UTF8.GetBytes(sTmp);
                            fs.Write(Bytes, 0, Bytes.Length);
                        }

                        break;
                }

                fs.Close();
            }
        }




        private void getTextFile_Click(object sender, EventArgs e)
        {
            lview_member.Items.Clear();

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "TextFile (*.txt) | *.txt";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadData(dlg.FileName);
                }
            }
        }
        private void LoadData(string fileName)
        {

            using (TextReader tReader = new StreamReader(fileName))
            {


                string[] stringLines
                    = tReader.ReadToEnd().Split('\n');


                foreach (string stringLine in stringLines)
                {

                    if (stringLine != string.Empty)
                    {

                        string[] stringArrays = stringLine.Split(',');

                        ListViewItem item = new ListViewItem(stringArrays);


                        lview_member.Items.Add(item);
                    }
                }
            }
        }


        private void button_FILELOAD_Click(object sender, EventArgs e)
        {

        }

        private void SEARCH_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }
}

