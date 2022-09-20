using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static cousrse_design.Program;

namespace cousrse_design
{
    public partial class Design : Form
    {
        public static Design form;
        public Design()
        {
            InitializeComponent();
        }
        private void Design_Load(object sender, EventArgs e)
        {
        }
        private void BtnZF_Click(object sender, EventArgs e)
        {
            if (BtnZF.BackColor == Color.White)
                BtnZF.BackColor = Color.Yellow;
            else
                BtnZF.BackColor = Color.White;
        }
        private void BtnZD_Click(object sender, EventArgs e)
        {
            if (BtnZD.BackColor == Color.White)
                BtnZD.BackColor = Color.Yellow;
            else
                BtnZD.BackColor = Color.White;
        }
        private void BtnDS_Click(object sender, EventArgs e)
        {
            if (BtnDS.BackColor == Color.White)
                BtnDS.BackColor = Color.Yellow;
            else
                BtnDS.BackColor = Color.White;
        }
        private void BtnDJ_Click(object sender, EventArgs e)
        {
            if (BtnDJ.BackColor == Color.White)
                BtnDJ.BackColor = Color.Yellow;
            else
                BtnDJ.BackColor = Color.White;
        }
        private void BtnDCFS_Click(object sender, EventArgs e)
        {
            if (BtnDCFS.BackColor == Color.White)
                BtnDCFS.BackColor = Color.Yellow;
            else
                BtnDCFS.BackColor = Color.White;
        }
        private void BtnDCJF_Click(object sender, EventArgs e)
        {
            if (BtnDCJF.BackColor == Color.White)
                BtnDCJF.BackColor = Color.Yellow;
            else
                BtnDCJF.BackColor = Color.White;
        }
        private void BtnZQA_Click(object sender, EventArgs e)
        {
            if (BtnZQA.BackColor == Color.White)
                BtnZQA.BackColor = Color.Yellow;
            else
                BtnZQA.BackColor = Color.White;
        }
        private void BtnZRA_Click(object sender, EventArgs e)
        {
            if (BtnZRA.BackColor == Color.White)
                BtnZRA.BackColor = Color.Yellow;
            else
                BtnZRA.BackColor = Color.White;
        }
        private void BtnGZSZ_Click(object sender, EventArgs e)
        {
            if (BtnGZSZ.BackColor == Color.White)
                BtnGZSZ.BackColor = Color.Yellow;
            else
                BtnGZSZ.BackColor = Color.White;
        }
        private void BtnYA_Click(object sender, EventArgs e)
        {
            if (BtnXYA.BackColor == Color.FromArgb(192, 192, 255))
                BtnXYA.BackColor = Color.Yellow;
            else
                BtnXYA.BackColor = Color.FromArgb(192, 192, 255);
            if (BtnXYA.BackColor == Color.Yellow)
            {
                X_1.FillColor = Color.Red;
                X_2.FillColor = Color.White;
            }
            if (BtnYZSA.BackColor == Color.Yellow)
            {  
                X_1.FillColor = Color.Yellow;
                X_2.FillColor = Color.Black;
                PQF form = new PQF();
                form.Show();
                timerSBBJ.Enabled = false;
                timerZSB.Enabled = true;
              
            }
        }
        private void timerSB_Tick(object sender, EventArgs e)
        {
            if (DC1.ForeColor == Color.Red)
            {
                DC1.ForeColor = Color.White;
            }
            else
                DC1.ForeColor = Color.Red;
        }
        private void BtnYDJS_Click(object sender, EventArgs e)
        {
            if (BtnYDJS.BackColor == Color.White)
                BtnYDJS.BackColor = Color.Yellow;
            else
                BtnYDJS.BackColor = Color.White;
        }
        private void BtnDCGZ_Click(object sender, EventArgs e)
        {
            if (BtnDCGZ.BackColor == Color.White)
                BtnDCGZ.BackColor = Color.Yellow;
            else
                BtnDCGZ.BackColor = Color.White;
        } 
        private void timerSBBJ_Tick(object sender, EventArgs e)
        {
            YYBJ.URL = @"F:\2017117730 唐泽龙计算机联锁仿真\JCBJ.M4A";
            YYBJ.Ctlcontrols.play();
        } 
        private void BtnYZSA_Click(object sender, EventArgs e)
        {
            if (BtnYZSA.BackColor == Color.White)
                BtnYZSA.BackColor = Color.Yellow;
            else
                BtnYZSA.BackColor = Color.White;
        }
        private void timerZSB_Tick(object sender, EventArgs e)
        {
            if(common.flag==1)
            {
                timerSB.Enabled = false;
                X_1.FillColor = Color.Red;
                X_2.FillColor = Color.White;
                DC1.ForeColor = Color.Red;
                DG1_2.Visible = true;
                DG1_2.BorderColor = Color.Lime;
                DC3.ForeColor = Color.Red;
                DC5.ForeColor = Color.Red;
                DC7.ForeColor = Color.Red;
                DC9.ForeColor = Color.Red;
                DC13.ForeColor = Color.Red;
                BtnYZSA.BackColor = Color.White;
                timerZSB.Enabled = false;
            }
        }
        private void DC1_Click(object sender, EventArgs e)
        {
            if (BtnZF.BackColor == Color.Yellow)
            {
                BtnZF.BackColor = Color.White;
                DG1_2.Visible = false;
                DG1_4.Visible = true;
                DC1.ForeColor = Color.Yellow;
                DG3_2.Visible = false;
                DG3_4.Visible = true;
                DC3.ForeColor = Color.Yellow;
            }
            if (BtnZD.BackColor == Color.Yellow)
            {
                BtnZD.BackColor = Color.White;
                DG1_2.Visible = true;
                DG1_4.Visible = false;
                DC1.ForeColor = Color.Lime;
                DG3_2.Visible = true;
                DG3_4.Visible = false;
                DC3.ForeColor = Color.Lime;
            }
            if (BtnDS.BackColor == Color.Yellow)
            {
                DS1.Visible = true;
                DS3.Visible = true;
                BtnDS.BackColor = Color.White;
            }
            if (BtnDJ.BackColor == Color.Yellow)
            {
                BtnDJ.BackColor = Color.White;
                DS1.Visible = false;
                DS3.Visible = false;
            }
            if (BtnDCFS.BackColor == Color.Yellow)
            {
                BtnDCFS.BackColor = Color.White;
                DC1.ForeColor = Color.Red;
                DC3.ForeColor = Color.Red;
            }
            if (BtnDCJF.BackColor == Color.Yellow)
            {
                BtnDCJF.BackColor = Color.White;
                if (DG1_2.Visible == true)
                {
                    DC1.ForeColor = Color.Lime;
                }
                else
                    DC1.ForeColor = Color.Yellow;
                if (DG3_2.Visible == true)
                {
                    DC3.ForeColor = Color.Lime;
                }
                else
                    DC3.ForeColor = Color.Yellow;
            }
            if (BtnGZSZ.BackColor == Color.Yellow)
            {
                DG1_1.BorderColor = Color.Red;
                DG1_2.BorderColor = Color.Red;
                DG1_3.BorderColor = Color.Red;
                BtnGZSZ.BackColor = Color.White;
            }
            if (BtnGZSZ.BackColor == Color.White&&BtnYDJS.BackColor == Color.Yellow)
            {
                DG1_1.BorderColor = Color.FromArgb(128, 128, 255);
                DG1_2.BorderColor=Color.Lime;
                DC1.ForeColor = Color.Lime;
                DC3.ForeColor = Color.Lime;
                DG1_3.BorderColor = Color.FromArgb(128, 128, 255);
                BtnYDJS.BackColor = Color.White;
            }
            if (BtnDCGZ.BackColor == Color.Yellow)
            {
                DG1_2.Visible = false;
                DG1_4.Visible = false;
                timerSB.Enabled = true;
                BtnDCGZ.BackColor = Color.White;
                timerSBBJ.Enabled = true;
            }
        }
        private void DC3_Click(object sender, EventArgs e)
        {
            if (BtnZF.BackColor == Color.Yellow)
            {
                BtnZF.BackColor = Color.White;
                DG1_2.Visible = false;
                DG1_4.Visible = true;
                DC1.ForeColor = Color.Yellow;
                DG3_2.Visible = false;
                DG3_4.Visible = true;
                DC3.ForeColor = Color.Yellow;
            }
            if (BtnZD.BackColor == Color.Yellow)
            {
                BtnZD.BackColor = Color.White;
                DG1_2.Visible = true;
                DG1_4.Visible = false;
                DC1.ForeColor = Color.Lime;
                DG3_2.Visible = true;
                DG3_4.Visible = false;
                DC3.ForeColor = Color.Lime;
            }
            if (BtnDS.BackColor == Color.Yellow)
            { 
                BtnDS.BackColor = Color.White;
                DS1.Visible = true;
                DS3.Visible = true;
            }
            if (BtnDJ.BackColor == Color.Yellow)
            {
                BtnDJ.BackColor = Color.White;
                DS1.Visible = false;
                DS3.Visible = false;
            }
            if (BtnDCFS.BackColor == Color.Yellow)
            {
                BtnDCFS.BackColor = Color.White;
                DC1.ForeColor = Color.Red;
                DC3.ForeColor = Color.Red;
            }
            if (BtnDCJF.BackColor == Color.Yellow)
            {   
                BtnDCJF.BackColor = Color.White;
                if (DG1_2.Visible == true)
                {
                    DC1.ForeColor = Color.Lime;
                }
                else
                    DC1.ForeColor = Color.Yellow;
                if (DG3_2.Visible == true)
                {
                    DC3.ForeColor = Color.Lime;
                }
                else
                    DC3.ForeColor = Color.Yellow;
            }
        }
        private void timerBJ_Tick(object sender, EventArgs e)
        {
            if (X_1.FillColor == Color.Red)
            {
                X_1.FillColor = Color.White;
            }
            else
                X_1.FillColor = Color.Red;
        }

        private void BtnBJ_Click(object sender, EventArgs e)
        {
            if (BtnBJ.BackColor == Color.White)
                BtnBJ.BackColor = Color.Yellow;
            else
                BtnBJ.BackColor = Color.White;
            if (BtnBJ.BackColor == Color.Yellow)
            {
                timerBJ.Enabled = true;
            }
            if(BtnBJ.BackColor == Color.White)
            {
                timerBJ.Enabled = false;
            }
        }
        private void timerJJ_Tick(object sender, EventArgs e)
        {
            if (IAG.BorderColor == Color.Blue && DG1_1.BorderColor == Color.Blue && DG1_3.BorderColor == Color.Blue && IG.BorderColor == Color.Blue)
            {
                //进路锁闭白光带
                IAG.BorderColor = Color.White;
                DG1_1.BorderColor = Color.White;
                DC1.ForeColor = Color.Red;
                DC3.ForeColor = Color.Red;
                DG1_3.BorderColor = Color.White;
                IG.BorderColor = Color.White;
                //开放信号
                X_1.FillColor = Color.Yellow;
                XY_1.FillColor = Color.Yellow;
                timerJJ.Enabled = false;
            }
        }
        private void BtnXLA_Click(object sender, EventArgs e)
        {
            if (BtnXLA.BackColor == Color.Green)
            {
                BtnXLA.BackColor = Color.Yellow;
            }
            else
                BtnXLA.BackColor = Color.Green;
            if (BtnZQA.BackColor == Color.Yellow)
            {
                BtnXLA.BackColor = Color.Green;
                BtnZQA.BackColor = Color.White;
                X_1.FillColor = Color.Red;
                IG.BorderColor = Color.FromArgb(128, 128, 255);
                DG1_3.BorderColor = Color.FromArgb(128, 128, 255);
                DC1.ForeColor = Color.Lime;
                DC3.ForeColor = Color.Lime;
                DG1_1.BorderColor = Color.FromArgb(128, 128, 255);
                IAG.BorderColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
            }
        }
        private void BtnSILA_Click(object sender, EventArgs e)
        {
            if (BtnXLA.BackColor == Color.Yellow)
            {
                BtnXLA.BackColor = Color.Green;
                //选路
                //转换道岔、检查道岔位置一致性7线
                DG1_2.Visible = true;
                DG1_4.Visible = false;
                DG3_2.Visible = true;
                DG3_4.Visible = false;
                //三大联锁条件检查
                IAG.BorderColor = Color.Blue;
                DG1_1.BorderColor = Color.Blue;
                DG1_3.BorderColor = Color.Blue;
                IG.BorderColor = Color.Blue;
                timerJJ.Enabled = true;
            }  
        } 
       private void timerFJ_Tick(object sender, EventArgs e)
        {
            //进路锁闭白光带
            if ( DG14_1.BorderColor == Color.Blue&& DG14_3.BorderColor == Color.Blue&& DG2_3.BorderColor == Color.Blue&&DG2_1.BorderColor == Color.Blue&&IBG.BorderColor == Color.Blue&&SJG.BorderColor == Color.Blue&&SYG.BorderColor == Color.Blue)
            {
                DG14_1.BorderColor = Color.White;
                DC14.ForeColor = Color.Red;
                DC12.ForeColor = Color.Red;
                DG14_3.BorderColor = Color.White;
                DG2_3.BorderColor = Color.White;
                DC2.ForeColor = Color.Red;
                DC4.ForeColor = Color.Red;
                DG2_1.BorderColor = Color.White;
                IBG.BorderColor = Color.White;
                SJG.BorderColor = Color.White;
                SYG.BorderColor = Color.White; 
                //开放信号
                XI_1.FillColor = Color.Lime;  
                timerFJ.Enabled = false;
            }
        }
       private void BtnXILA_Click(object sender, EventArgs e)
        {
            if (BtnXILA.BackColor == Color.Green)
            {
                BtnXILA.BackColor = Color.Yellow;
            }
            else
                BtnXILA.BackColor = Color.Green;
        }
        private void BtnSLA_Click(object sender, EventArgs e)
        {
            if ( BtnXILA.BackColor == Color.Yellow)
            {
                BtnXILA.BackColor = Color.Green;
                // 选路
                //转换道岔、检查道岔位置一致性7线
                DG2_2.Visible = true;
                DG2_4.Visible = false;
                DG4_2.Visible = true;
                DG4_4.Visible = false;
                //三大联锁条件检查      
                DG14_1.BorderColor = Color.Blue;
                DG14_3.BorderColor = Color.Blue;
                DG2_3.BorderColor = Color.Blue;
                DG2_1.BorderColor = Color.Blue;
                IBG.BorderColor = Color.Blue;
                SJG.BorderColor = Color.Blue;
                SYG.BorderColor = Color.Blue;
                timerFJ.Enabled = true;
            }     
        }
        private void timerD3_Tick(object sender, EventArgs e)
        {
            if(D3_1.FillColor == Color.Blue|| D3_1.FillColor == Color.Black)
            {
                D3_1.FillColor =Color.White;
                D3_1.BorderColor = Color.White;
            }
            else
                D3_1.FillColor = Color.Black;
                D3_1.BorderColor = Color.White;
        }
        private void D3_1_Click(object sender, EventArgs e)
        {
            timerD3.Enabled = true;
        }
        private void timerRJD_Tick(object sender, EventArgs e)
        {
            if(common.flag==1)
            {
                DJS.Visible = true;
                DJS.Text = common.time.ToString();
                common.time--;
            } 
            if(common.time==-1)
            {
                DJS.Visible = false;
                DG3_1.BorderColor = Color.FromArgb(128, 128, 255);
                DC1.ForeColor = Color.Lime;
                DC3.ForeColor = Color.Lime;
                DG3_3.BorderColor = Color.FromArgb(128, 128, 255);
                DG5_1.BorderColor = Color.FromArgb(128, 128, 255);
                DC5.ForeColor = Color.Lime;
                DG5_3.BorderColor = Color.FromArgb(128, 128, 255);
                G2.BorderColor = Color.FromArgb(128, 128, 255);
                BtnZRA.BackColor = Color.White;
                timerRJD.Enabled = false;
                D3_1.FillColor = Color.Blue;
                D3_1.BorderColor = Color.Blue;
                D5_1.FillColor = Color.Blue;
                D5_1.BorderColor = Color.Blue;
            }
        }
        private void D3M_Click(object sender, EventArgs e)
        {
           if(BtnZRA.BackColor==Color.Yellow)
           {
                PQF form = new PQF();
                form.Show();   
                timerRJD.Enabled = true;     
           }           
        } 
        private void timerDJ_Tick(object sender, EventArgs e)
        {
            //进路锁闭白光带
            if (G2.BorderColor == Color.Blue)
            {
                G2.BorderColor = Color.White; 
            }
            if(DG5_1.BorderColor == Color.White&& DG5_3.BorderColor == Color.White)
            { 
             DG3_1.BorderColor = Color.White;
             DC1.ForeColor = Color.Red;
             DC3.ForeColor = Color.Red;
             DG3_3.BorderColor = Color.White;
             //开放信号 
             D3_1.FillColor = Color.White;
             D3_1.BorderColor = Color.White;
            timerDJ.Enabled = false;
            }   
        }
        private void S2_2_Click(object sender, EventArgs e)
        {
            if(timerD3.Enabled==true)
            { 
              timerD3.Enabled = false;
            //选路
            //转换道岔、检查道岔位置一致性7线
            DG3_2.Visible = true;
            DG3_4.Visible = false;
            DG5_2.Visible = true;
            DG5_4.Visible = false;
            //三大联锁条件检查
            DG3_1.BorderColor = Color.Blue;
            DG3_3.BorderColor = Color.Blue ;
            DG5_1.BorderColor = Color.Blue; 
            DG5_3.BorderColor = Color.Blue;
            G2.BorderColor = Color.Blue;
            timerDJ.Enabled = true;
            }
            
        } 
        private void D5_1_Click(object sender, EventArgs e)
        {
         if (G2.BorderColor == Color.White)
            {
                DG5_1.BorderColor = Color.White;
                DC5.ForeColor = Color.Red;
                DG5_3.BorderColor = Color.White;
                D5_1.FillColor = Color.White;
                D5_1.BorderColor = Color.White;
            }
        }  
        private void timerGO_Tick(object sender, EventArgs e)
        {
            C001.Left += 3;
            if(X_1.FillColor==Color.Yellow)
            {
                if (C001.Left>=XJG.X1 && C001.Left+ C001.Width <= XJG.X2)
                {
                    XJG.BorderColor = Color.Red;
                    XY_1.FillColor = Color.Red;//轨道区段有车点红灯
                }
                if(C001.Left + C001.Width >= IAG.X1)
                {
                    BtnXLA.BackColor = Color.Green;
                    BtnSILA.BackColor = Color.Green;
                    X_1.FillColor = Color.Red;//进入IAG无岔区段就点红灯
                }
            }
            else
            { 
                if(BtnXYA.BackColor == Color.FromArgb(192, 192, 255))
                {
                if(C001.Left+C001.Width>IAG.X1&&C001.Left+ C001.Width <= IAG.X2)
                {                  
                    IAG.BorderColor = Color.Red;
                }

                if (C001.Left >=IAG.X1+3 && C001.Left + C001.Width <= IAG.X2)
                 {
                        XJG.BorderColor = Color.FromArgb(128, 128, 255);                      
                 }
                if (C001.Left+ C001.Width >= DG1_1.X1&&C001.Left+ C001.Width <= DG1_1.X2)
                {
                    DG1_1.BorderColor = Color.Red;
                    DG1_2.BorderColor = Color.Red;
                    DG1_3.BorderColor = Color.Red;                    
                }
                if (C001.Left >= DG1_1.X1 && C001.Left + C001.Width <= DG1_1.X2)
                {
                        IAG.BorderColor = Color.FromArgb(128, 128, 255);
                }
                if (C001.Left+C001.Width >= IG.X1 && C001.Left + C001.Width <= IG.X2)
                {  
                        IG.BorderColor = Color.Red;                      
                }
                if (C001.Left>= IG.X1+3 && C001.Left + C001.Width <= IG.X2)
                {
                    DG1_1.BorderColor = Color.FromArgb(128, 128, 255);
                    DG1_2.BorderColor = Color.Lime;
                    DC1.ForeColor = Color.Lime;
                    DG1_3.BorderColor = Color.FromArgb(128, 128, 255);                   
                    timerGO.Enabled = false;
                }
                }
                else
                {
                if (C001.Left + C001.Width >= IAG.X1 + 3 && C001.Left + C001.Width <= IAG.X2)
                {                   
                    IAG.BorderColor = Color.Red;
                }
                if (C001.Left >= IAG.X1 + 3 && C001.Left + C001.Width <= IAG.X2)
                {
                        XJG.BorderColor = Color.FromArgb(128, 128, 255);
                }
                if (C001.Left + C001.Width >= DG1_1.X1  && C001.Left + C001.Width <= DG1_1.X2)
                {
                    DG1_1.BorderColor = Color.Red;
                    DG1_2.BorderColor = Color.Red;
                    DG1_3.BorderColor = Color.Red;
                }
                if (C001.Left+C001.Width >= IG.X1 && C001.Left + C001.Width <= IG.X2)
               {
                        IG.BorderColor = Color.Red;                     
                }
                if (C001.Left >= IG.X1 + 3 && C001.Left + C001.Width <= IG.X2)
                {                    
                    timerGO.Enabled = false;
                    BtnXYA.BackColor = Color.FromArgb(192, 192, 255);
                   if(BtnYDJS.BackColor==Color.Yellow)
                   { 
                     IAG.BorderColor = Color.FromArgb(128, 128, 255);
                     IG.BorderColor = Color.FromArgb(128, 128, 255);
                   }
                }
                
                }   
            }
            if (X_1.FillColor == Color.Red&&X_2.FillColor==Color.White)
                {
                    if (C001.Left >= XJG.X1 && C001.Left + C001.Width <= XJG.X2)
                    {
                        XJG.BorderColor = Color.Red;
                        XY_1.FillColor = Color.Red;//轨道区段有车点红灯
                    }
                    if (C001.Left + C001.Width >= IAG.X1)
                    {
                        BtnXLA.BackColor = Color.Green;
                        BtnSILA.BackColor = Color.Green;
                        X_1.FillColor = Color.Red;
                        X_2.FillColor = Color.Black;//进入IAG无岔区段就点红灯
                    }
                 }         
        }
        private void BtnGO_Click(object sender, EventArgs e)
        {
            timerGO.Enabled = true;   
        }     
    }
}
