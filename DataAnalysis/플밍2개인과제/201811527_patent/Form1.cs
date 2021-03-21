using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace _201811527_patent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable patenttable = new CSVManager("./개인과제data.csv").datatable;


        
        private void DataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        //검색기능 시작 박스 누르면 텍스트 없어짐
        private void Search_Click(object sender, EventArgs e)
        {
            search.Text = null;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            
        }
        //특허 상세정보 보여주기
        private void CheckedListBox1_Click(object sender, EventArgs e)
        {
            
        }
        //기본 기능 장바구니 저장
        private void Button5_Click(object sender, EventArgs e)
        {
            
        }

        //복합기능시작
        private void Search_Term1_Click(object sender, EventArgs e)
        {
            Search_Term1.Text = null;
        }

        /*
        Form2 f2 = new Form2();
        private void Button1_Click(object sender, EventArgs e)
        {
            string searchtxt = Search_Term1.Text;

            if (searchtxt == "")
            {
                MessageBox.Show("검색어를 입력해주세요.");
            }
            else if (searchtxt == "검색어를 입력해주세요.")
            {
                MessageBox.Show("검색어를 입력해주세요.");
            }
            //* 포함하고있을 때
            else if (searchtxt.Contains('*'))
            {
                string firstword = searchtxt.Split('*')[0].Trim(); //특허
                string secondword = searchtxt.Split('*')[1].Trim(); //발명자
                ArrayList firres = new ArrayList(); //특허검색결과
                ArrayList secres = new ArrayList(); //발명자검색결과

                for (int i = 1; i < patenttable.Rows.Count; i++)
                {
                    string firline = patenttable.Rows[i][2].ToString();
                    string secline = patenttable.Rows[i][4].ToString();

                    if (firline.Contains(firstword))
                    {
                        if (firres.Contains(firline))
                        {
                        }
                        else
                        {
                            firres.Add(firline);
                        }
                    }
                    if (secline.Contains(secondword))
                    {
                        if (firres.Contains(firline))
                        {
                            secres.Add(firline);
                        }
                        else
                        {
                        }
                    }
                }
                foreach (string item in secres)
                {
                    f2.checkedListBox1.Items.Add(item);
                    if (f2.checkedListBox1.Items.Count == 0)
                    {
                        MessageBox.Show($"{secondword}(이/가) 발명한 {firstword} 특허를 찾을 수 없습니다.");
                    }
                    else
                    {
                        f2.label1.Text = $"복합 기능 검색 결과 : {f2.checkedListBox1.Items.Count}건";
                        f2.Show();
                    }
                }
            }
            else if (searchtxt.Contains('#'))
            {
                string firstword = searchtxt.Split('#')[0].Trim(); //특허1
                string secondword = searchtxt.Split('#')[1].Trim(); //특허2
                ArrayList firres = new ArrayList(); //특허1결과
                ArrayList secres = new ArrayList(); //특허2결과

                for (int i = 1; i < patenttable.Rows.Count; i++)
                {
                    string firline = patenttable.Rows[i][3].ToString();

                    if (firline.Contains(firstword))
                    {
                        if (firres.Contains(patenttable.Rows[i][2].ToString()))
                        {
                        }
                        else
                        {
                            firres.Add(patenttable.Rows[i][2]); //첫번쨰 단어를 갖고있으면 firres에 넣음
                        }
                    }
                    if (firline.Contains(secondword))
                    {
                        if (firres.Contains(patenttable.Rows[i][2].ToString()))
                        {
                            secres.Add(patenttable.Rows[i][2]);
                        }
                        else
                        {
                        }
                    }
                }
                foreach (string item in secres)
                {
                    f2.checkedListBox1.Items.Add(item);
                    if (f2.checkedListBox1.Items.Count == 0)
                    {
                        MessageBox.Show($"{secondword}(와/과) {firstword}를 모두 포함하는 특허를 찾을 수 없습니다.");
                    }
                    else
                    {
                        f2.label1.Text = $"복합 기능 검색 결과 : {f2.checkedListBox1.Items.Count}건";
                        f2.Show();
                    }
                }
            }
            //not 기능
            else if (searchtxt.Contains('!'))
            {
                string firstword = searchtxt.Split('!')[0].Trim(); //포함되어야 하는 특허
                string secondword = searchtxt.Split('!')[1].Trim(); //포함되면 안되는 특허
                ArrayList firres = new ArrayList(); //특허검색결과

                for (int i = 1; i < patenttable.Rows.Count; i++)
                {
                    string firline = patenttable.Rows[i][2].ToString();

                    if (firline.Contains(firstword))
                    {
                        if (firres.Contains(firline))
                        {
                        }
                        else
                        {
                            firres.Add(firline);
                        }
                    }
                    if (firline.Contains(secondword))
                    {
                        if (firres.Contains(firline))
                        {
                            firres.Remove(firline);
                        }
                        else
                        {
                        }
                    }
                }
                foreach (string item in firres)
                {
                    f2.checkedListBox1.Items.Add(item);
                    if (f2.checkedListBox1.Items.Count == 0)
                    {
                        MessageBox.Show($"{secondword}(이/가) 제외된 {firstword} 특허를 찾을 수 없습니다.");
                    }
                    else
                    {
                        f2.label1.Text = $"복합 기능 검색 결과 : {f2.checkedListBox1.Items.Count}건";
                        f2.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("단순검색기능을 이용해주세요.");
            }
        }
        */

        private void Allbutton_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = patenttable;
            MessageBox.Show($"{dataGridView1.Rows.Count}개의 특허가 조회되었습니다.");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        public DataTable savetable;
        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form3 f3 = new Form3();
            //Form4에 클릭한 특허 정보를 기입한 후, 팝업     
            int current_idx = dataGridView1.CurrentRow.Index;
            String current_num = dataGridView1.Rows[current_idx].Cells["app_num"].Value.ToString();
            f3.lbl_num.Text = $"특허 번호:{current_num}";
            String current_date = dataGridView1.Rows[current_idx].Cells["app_date"].Value.ToString();
            f3.lbl_date.Text = $"특허 날짜:{current_date}";
            String current_title = dataGridView1.Rows[current_idx].Cells["title"].Value.ToString();
            f3.title_box.Text = $"{current_title}";
            string current_inventors = dataGridView1.Rows[current_idx].Cells["inventors"].Value.ToString();
            f3.inv_box.Text = $"{current_inventors}";
            string current_abs = dataGridView1.Rows[current_idx].Cells["abstract"].Value.ToString();
            f3.abs_box.Text = $"{current_abs}";

            f3.Show();
        }

        private void Search_Click_1(object sender, EventArgs e)
        {
            search.Text = null;
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            string searchtxt = search.Text;
            //제목 검색일떄
            if (comboBox1.SelectedIndex == 0)
            {
                if (searchtxt == "")
                {
                    MessageBox.Show("검색어를 입력해주세요.");
                }
                else if (searchtxt == "검색어를 입력해주세요.")
                {
                    MessageBox.Show("검색어를 입력해주세요.");
                }
                else
                {
                    for (int i = 1; i < patenttable.Rows.Count; i++)
                    {
                        string line = patenttable.Rows[i][2].ToString();

                        if (line.Contains(searchtxt))
                        {
                            if (checkedListBox1.Items.Contains(line))
                            {
                            }
                            else
                            {
                                checkedListBox1.Items.Add(line);
                            }
                        }

                    }
                    if (checkedListBox1.Items.Count == 0)
                    {
                        MessageBox.Show($"{searchtxt}를 포함하는 제목을 가진 특허 검색결과가 없습니다.");
                    }
                    else
                    {
                        MessageBox.Show($"{checkedListBox1.Items.Count}건의 특허가 검색되었습니다.");
                    }
                }
            }
            //발명자 검색
            else if (comboBox1.SelectedIndex == 1)
            {
                if (searchtxt == "")
                {
                    MessageBox.Show("검색어를 입력해주세요.");
                }
                else if (searchtxt == "검색어를 입력해주세요.")
                {
                    MessageBox.Show("검색어를 입력해주세요.");
                }
                else
                {
                    for (int i = 1; i < patenttable.Rows.Count; i++)
                    {
                        string line = patenttable.Rows[i][4].ToString();

                        if (line.Contains(searchtxt))
                        {
                            if (checkedListBox1.Items.Contains(line))
                            {
                            }
                            else
                            {
                                checkedListBox1.Items.Add(line);
                            }
                        }
                        else
                        {
                        }
                    }
                    if (checkedListBox1.Items.Count == 0)
                    {
                        MessageBox.Show($"{searchtxt}(이/가) 발명한 특허 검색결과가 없습니다.");
                    }
                    else
                    {
                        MessageBox.Show($"{checkedListBox1.Items.Count}건의 특허가 검색되었습니다.");
                    }
                }
            }
            //번호
            else if (comboBox1.SelectedIndex == 2)
            {
                if (searchtxt == "")
                {
                    MessageBox.Show("검색어를 입력해주세요.");
                }
                else if (searchtxt == "검색어를 입력해주세요.")
                {
                    MessageBox.Show("검색어를 입력해주세요.");
                }
                else
                {
                    for (int i = 1; i < patenttable.Rows.Count; i++)
                    {
                        string line = patenttable.Rows[i][0].ToString();

                        if (line.Contains(searchtxt))
                        {
                            if (checkedListBox1.Items.Contains(line))
                            {
                            }
                            else
                            {
                                checkedListBox1.Items.Add(line);
                            }
                        }

                    }
                    if (checkedListBox1.Items.Count == 0)
                    {
                        MessageBox.Show($"해당{searchtxt}번호를 포함하는 특허 검색결과가 없습니다.");
                    }
                    else
                    {
                        MessageBox.Show($"{checkedListBox1.Items.Count}건의 특허가 검색되었습니다.");
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                if (searchtxt == "")
                {
                    MessageBox.Show("검색어를 입력해주세요.");
                }
                else if (searchtxt == "검색어를 입력해주세요.")
                {
                    MessageBox.Show("검색어를 입력해주세요.");
                }
                else
                {
                    for (int i = 1; i < patenttable.Rows.Count; i++)
                    {
                        string line = patenttable.Rows[i][2].ToString();

                        if (line.Contains(searchtxt))
                        {
                            if (checkedListBox1.Items.Contains(line))
                            {

                            }
                            else
                            {
                                checkedListBox1.Items.Add(line);
                            }
                        }

                    }
                    if (checkedListBox1.Items.Count == 0)
                    {
                        MessageBox.Show($"{searchtxt}를 포함하는 초록 검색결과가 없습니다.");
                    }
                    else
                    {
                        MessageBox.Show($"{checkedListBox1.Items.Count}건의 특허가 검색되었습니다.");
                    }
                }
            }
            else
            {
                MessageBox.Show("분류를 선택해주세요.");
            }
        }

        private void CheckedListBox1_Click_1(object sender, EventArgs e)
        {
            object item = checkedListBox1.SelectedItem;
            for (int i = 0; i < patenttable.Rows.Count; i++)
            {
                for (int j = 0; j < patenttable.Columns.Count; j++)
                {
                    if (item == patenttable.Rows[i][j])
                    {
                        textBox11.Text = patenttable.Rows[i][0].ToString();
                        textBox10.Text = patenttable.Rows[i][1].ToString();
                        textBox9.Text = patenttable.Rows[i][2].ToString();
                        textBox12.Text = patenttable.Rows[i][3].ToString();
                        textBox8.Text = patenttable.Rows[i][4].ToString();
                        textBox7.Text = patenttable.Rows[i][5].ToString();
                    }
                }
            }
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                for (int i = 0; i < patenttable.Rows.Count; i++)
                {
                    for (int j = 0; j < patenttable.Columns.Count; j++)
                    {
                        if (item == patenttable.Rows[i][j])
                        {
                            string additem = patenttable.Rows[i][2].ToString();
                            checkedListBox2.Items.Add(additem);
                        }
                    }
                }
            }
            MessageBox.Show($"{checkedListBox1.CheckedItems.Count}건의 특허가 저장되었습니다.");
            checkedListBox1.ClearSelected();
        }
        //장바구니 리스트 클릭
        private void CheckedListBox2_Click(object sender, EventArgs e)
        {

            object item = checkedListBox2.SelectedItem;
            for (int i = 0; i < patenttable.Rows.Count; i++)
            {
                for (int j = 0; j < patenttable.Columns.Count; j++)
                {
                    if (item == patenttable.Rows[i][j])
                    {
                        textBox1.Text = patenttable.Rows[i][0].ToString();
                        textBox2.Text = patenttable.Rows[i][1].ToString();
                        textBox3.Text = patenttable.Rows[i][2].ToString();
                        textBox13.Text = patenttable.Rows[i][3].ToString();
                        textBox4.Text = patenttable.Rows[i][4].ToString();
                        textBox5.Text = patenttable.Rows[i][5].ToString();
                    }
                }
            }
        }
        //장바구니 삭제
        private void Button2_Click(object sender, EventArgs e)
        {
            ArrayList dellist = new ArrayList();
            int delcount = checkedListBox2.CheckedItems.Count;

            if (delcount == 0)
            {
                MessageBox.Show("선택된 특허가 없습니다.");
            }
            else
            {
                for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                {
                    dellist.Add(checkedListBox2.CheckedItems[i]);
                }
                foreach (var item in dellist)
                {
                    checkedListBox2.Items.Remove(item);
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox13.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            MessageBox.Show($"{delcount}건의 특허가 삭제되었습니다.");
        }
        //장바구니 전체 삭제
        private void Button6_Click(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox13.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            MessageBox.Show("저장된 특허가 모두 삭제되었습니다.");
        }
        //장바구니 저장
        private void Button3_Click(object sender, EventArgs e)
        {
            string col1 = "app_num";
            string col2 = "app_date";
            string col3 = "title";
            string col4 = "abstract";
            string col5 = "investors";
            string col6 = "CPCs";

            using (StreamWriter writer = new StreamWriter("./장바구니data.csv"))
            {
                writer.WriteLine($"{col1},{col2},{col3},{col4},{col5},{col6}");

                for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                {
                    object selitem = checkedListBox2.CheckedItems[i];
                    for (int j = 0; j < patenttable.Rows.Count; j++)
                    {
                        for (int k = 0; k < patenttable.Columns.Count; k++)
                        {
                            if (selitem == patenttable.Rows[j][k])
                            {
                                string num = patenttable.Rows[j][0].ToString();
                                string date = patenttable.Rows[j][1].ToString();
                                string title = patenttable.Rows[j][2].ToString();
                                string abs = patenttable.Rows[j][3].ToString();
                                string inv = patenttable.Rows[j][4].ToString();
                                string cpcs = patenttable.Rows[j][5].ToString();

                                writer.WriteLine($"{num},{date},{title},{abs},{inv},{cpcs}");
                            }
                        }
                    }
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox13.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            MessageBox.Show("파일을 저장했습니다.");
        }

        private void Search_Term1_Click_1(object sender, EventArgs e)
        {
            Search_Term1.Text = null;
        }

        //복합기능시작
        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            string searchtxt = Search_Term1.Text;

            if (searchtxt == "")
            {
                MessageBox.Show("검색어를 입력해주세요.");
            }
            else if (searchtxt == "검색어를 입력해주세요.")
            {
                MessageBox.Show("검색어를 입력해주세요.");
            }
            //* 포함하고있을 때
            else if (searchtxt.Contains('*'))
            {
                string firstword = searchtxt.Split('*')[0].Trim(); //특허
                string secondword = searchtxt.Split('*')[1].Trim(); //발명자
                ArrayList firres = new ArrayList(); //특허검색결과
                ArrayList secres = new ArrayList(); //발명자검색결과

                for (int i = 1; i < patenttable.Rows.Count; i++)
                {
                    string firline = patenttable.Rows[i][2].ToString();
                    string secline = patenttable.Rows[i][4].ToString();

                    if (firline.Contains(firstword))
                    {
                        if (firres.Contains(firline))
                        {
                        }
                        else
                        {
                            firres.Add(firline);
                        }
                    }
                    if (secline.Contains(secondword))
                    {
                        if (firres.Contains(firline))
                        {
                            secres.Add(firline);
                        }
                        else
                        {
                        }
                    }
                }
                foreach (string item in secres)
                {
                    f2.checkedListBox1.Items.Add(item);
                    if (f2.checkedListBox1.Items.Count == 0)
                    {
                        MessageBox.Show($"{secondword}(이/가) 발명한 {firstword} 특허를 찾을 수 없습니다.");
                    }
                    else
                    {
                        f2.label1.Text = $"복합 기능 검색 결과 : {f2.checkedListBox1.Items.Count}건";
                        f2.Show();
                    }
                }
            }
            else if (searchtxt.Contains('#'))
            {
                string firstword = searchtxt.Split('#')[0].Trim(); //특허1
                string secondword = searchtxt.Split('#')[1].Trim(); //특허2
                ArrayList firres = new ArrayList(); //특허1결과
                ArrayList secres = new ArrayList(); //특허2결과

                for (int i = 1; i < patenttable.Rows.Count; i++)
                {
                    string firline = patenttable.Rows[i][3].ToString();

                    if (firline.Contains(firstword))
                    {
                        if (firres.Contains(patenttable.Rows[i][2].ToString()))
                        {
                        }
                        else
                        {
                            firres.Add(patenttable.Rows[i][2]); //첫번쨰 단어를 갖고있으면 firres에 넣음
                        }
                    }
                    if (firline.Contains(secondword))
                    {
                        if (firres.Contains(patenttable.Rows[i][2].ToString()))
                        {
                            secres.Add(patenttable.Rows[i][2]);
                        }
                        else
                        {
                        }
                    }
                }
                foreach (string item in secres)
                {
                    f2.checkedListBox1.Items.Add(item);
                    if (f2.checkedListBox1.Items.Count == 0)
                    {
                        MessageBox.Show($"{secondword}(와/과) {firstword}를 모두 포함하는 특허를 찾을 수 없습니다.");
                    }
                    else
                    {
                        f2.label1.Text = $"복합 기능 검색 결과 : {f2.checkedListBox1.Items.Count}건";
                        f2.Show();
                    }
                }
            }
            //not 기능
            else if (searchtxt.Contains('!'))
            {
                string firstword = searchtxt.Split('!')[0].Trim(); //포함되어야 하는 특허
                string secondword = searchtxt.Split('!')[1].Trim(); //포함되면 안되는 특허
                ArrayList firres = new ArrayList(); //특허검색결과

                for (int i = 1; i < patenttable.Rows.Count; i++)
                {
                    string firline = patenttable.Rows[i][2].ToString();

                    if (firline.Contains(firstword))
                    {
                        if (firres.Contains(firline))
                        {
                        }
                        else
                        {
                            firres.Add(firline);
                        }
                    }
                    if (firline.Contains(secondword))
                    {
                        if (firres.Contains(firline))
                        {
                            firres.Remove(firline);
                        }
                        else
                        {
                        }
                    }
                }
                foreach (string item in firres)
                {
                    f2.checkedListBox1.Items.Add(item);
                    if (f2.checkedListBox1.Items.Count == 0)
                    {
                        MessageBox.Show($"{secondword}(이/가) 제외된 {firstword} 특허를 찾을 수 없습니다.");
                    }
                    else
                    {
                        f2.label1.Text = $"복합 기능 검색 결과 : {f2.checkedListBox1.Items.Count}건";
                        f2.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("단순검색기능을 이용해주세요.");
            }
        }
    }
}
