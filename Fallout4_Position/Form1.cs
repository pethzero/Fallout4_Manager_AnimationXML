using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fallout4_Position
{
    public partial class Fallout4TreeXML : Form
    {
        // สร้าง instance ของคลาส SystemF4
        private SystemF4 FromSystemF4;

        public Fallout4TreeXML()
        {
            InitializeComponent();
            FromSystemF4 = new SystemF4(this);
        }

        private void btn_process(object sender, EventArgs e)
        {
            try
            {
                bool success = FromSystemF4.Process_Positon(tbx_Head.Text.Trim(), rtbTagAG.Text.Trim()); // เรียกใช้งาน Process_Position() เพื่อทำการประมวลผลและเก็บค่าที่รีเทิร์นกลับมา

                if (success)
                {
                    // กรณีที่การประมวลผลสำเร็จ
                    tbx_Head.Text = "";
                    rtbTagAG.Text = "";
                    MessageBox.Show("Process completed successfully!");
                }
                else
                {
                    // กรณีที่การประมวลผลไม่สำเร็จ
                    MessageBox.Show("Process failed!");
                }
            }
            catch (Exception ex)
            {
                // จัดการข้อผิดพลาดที่เกิดขึ้น
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}
