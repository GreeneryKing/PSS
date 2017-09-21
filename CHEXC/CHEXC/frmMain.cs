using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Download by http://www.codefans.net
namespace CHEXC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string strName)
        {
            InitializeComponent();
            SendNameValue = strName;
        }
        public string SendNameValue;
        private void menuGoodsIn_Click(object sender, EventArgs e)
        {
            //������Ϣ
           /* frmJhGoodsInfo jhGOOD = new frmJhGoodsInfo();
            jhGOOD.Owner = this;
            jhGOOD.ShowDialog();*/
            frmJhGoodsInfo delmember = new frmJhGoodsInfo();
            delmember.TopLevel = false;
            delmember.MdiParent = this;

            delmember.Show();
        }

        private void menuEmployee_Click(object sender, EventArgs e)
        {
            //Ա����Ϣ
           /* frmEmpInfo empinfo = new frmEmpInfo();
            empinfo.Owner = this;
            empinfo.ShowDialog();*/
            frmEmpInfo delmember = new frmEmpInfo();
            delmember.TopLevel = false;
            delmember.MdiParent = this;

            delmember.Show();
        }

        private void menuCompany_Click(object sender, EventArgs e)
        {
            //��Ӧ����Ϣ
           /* frmCompanyInfo frmComp = new frmCompanyInfo();
            frmComp.Owner = this;
            frmComp.ShowDialog();*/
            frmCompanyInfo delmember = new frmCompanyInfo();
            delmember.TopLevel = false;
            delmember.MdiParent = this;

            delmember.Show();
        }

        private void menuFind_Click(object sender, EventArgs e)
        {
            //��Ʒ��Ϣ���ѯ
           /* frmFindGood findgood = new frmFindGood();
            findgood.Owner = this;
            findgood.ShowDialog();*/
            frmFindGood delmember = new frmFindGood();
            delmember.TopLevel = false;
            delmember.MdiParent = this;
            delmember.Show();
        }

        private void menuDepotAlarm_Click(object sender, EventArgs e)
        {
            //��澯��
          /*  frmKcGoods kcGood = new frmKcGoods();
            kcGood.Owner = this;
            kcGood.ShowDialog();*/
            frmKcGoods delmember = new frmKcGoods();
            delmember.TopLevel = false;
            delmember.MdiParent = this;
            delmember.Show();
        }

        private void menuDepotFind_Click(object sender, EventArgs e)
        {
            //����ѯ
           /* frmKcGoodFind kcfrmFind = new frmKcGoodFind();
            kcfrmFind.Owner = this;
            kcfrmFind.ShowDialog();*/
            frmKcGoodFind delmember = new frmKcGoodFind();
            delmember.TopLevel = false;
            delmember.MdiParent = this;
            delmember.Show();
        }

        private void menuSellGoods_Click(object sender, EventArgs e)
        {
            //��Ʒ������Ϣ
            /*frmSellGoods frmSell = new frmSellGoods();
            frmSell.Owner = this;
            frmSell.ShowDialog();*/
            frmSellGoods delmember = new frmSellGoods();
            delmember.TopLevel = false;
            delmember.MdiParent = this;
            delmember.Show();
        }

        private void menuSellFind_Click(object sender, EventArgs e)
        {
            //�˻���Ϣ
           /* frmThGoodsInfo frmTh = new frmThGoodsInfo();
            frmTh.Owner = this;
            frmTh.ShowDialog();*/
            frmThGoodsInfo delmember = new frmThGoodsInfo();
            delmember.TopLevel = false;
            delmember.MdiParent = this;
            delmember.Show();
        }

        private void ���ݱ���HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���ݱ���
            frmDataBack frmBack = new frmDataBack();
            frmBack.Owner = this;
            frmBack.ShowDialog();
        }

        private void ���ݻ�ԭIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���ݻ�Դ
            frmDataReole frmReole = new frmDataReole();
            frmReole.Owner = this;
            frmReole.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            //this.statusUser.Text = "ϵͳ����Ա��" + SendNameValue;
            this.statusUser.Text = "ϵͳ����Ա��" + SendNameValue;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
   
            this.statusTime.Text = "��ǰʱ�䣺" + DateTime.Now.ToString();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ���µ�½ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //�˳�-���µ�½
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void ֱ���˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //�˳�-ֱ���˳�
            Application.Exit();
        }

        private void ��½����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //��������-��¼����
            System.Diagnostics.Process.Start("https://www.baidu.com/");
        }

        private void ����ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //��������-����Excel
            System.Diagnostics.Process.Start("excel.exe");
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.EXE");
        }

        private void ϵͳ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ϵͳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClearTable frmReole = new frmClearTable();
            frmReole.Owner = this;
            frmReole.ShowDialog();
        }
    }
}