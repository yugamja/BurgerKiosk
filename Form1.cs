namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            gbo_menu.TabStop = false;
            gbo_option.TabStop = false;

            rdoHamBurger.TabStop = true;   // 시작점
            rdoBulgogiBurger.TabStop = false;
            rdoChickenBurger.TabStop = false;

            chkPotato.TabStop = true;

            chkCola.TabStop = false;
            chkCheese.TabStop = false;
            chkSauce.TabStop = false;

            btn_order.TabStop = false;
            btn_reset.TabStop = false;

            lstOrder.TabStop = false;

            rdoHamBurger.KeyDown += chk_KeyDown;
            rdoBulgogiBurger.KeyDown += chk_KeyDown;
            rdoChickenBurger.KeyDown += chk_KeyDown;

            this.AcceptButton = btn_order;


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
    {
                if (this.ActiveControl == rdoHamBurger)
                {
                    chkPotato.Focus();
                }
                else if (this.ActiveControl == chkPotato)
                {
                    rdoHamBurger.Focus();
                }

                e.Handled = true;
            }
        }

        int totalCost = 0;
        private void UpdateList()
        {
            totalCost = 0;   // ⭐ 매번 초기화
            lstOrder.Items.Clear();

            // 메뉴
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            // 옵션
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

         
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.Text = "메뉴를 선택하세요";
                lblTotalCost.ForeColor = Color.Red;
            }
            else
            {
                lblTotalCost.Text = "총 합계: " + totalCost.ToString("N0") + "원";
                lblTotalCost.ForeColor = Color.Blue;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 합계: 0원";
            lblTotalCost.ForeColor = Color.Blue;
        }

        
        private void btn_order_Click(object sender, EventArgs e)
        {
            

            lblTotalCost.Text = "총 합계: " + totalCost.ToString("N0") + "원";
            lblTotalCost.ForeColor = Color.Blue;

            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.Text = "메뉴를 선택하세요";
                lblTotalCost.ForeColor = Color.Red;
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoHamBurger.CheckedChanged += (s, e) => UpdateList();
            rdoBulgogiBurger.CheckedChanged += (s, e) => UpdateList();
            rdoChickenBurger.CheckedChanged += (s, e) => UpdateList();
            chkPotato.CheckedChanged += (s, e) => UpdateList();
            chkCola.CheckedChanged += (s, e) => UpdateList();
            chkCheese.CheckedChanged += (s, e) => UpdateList();
            chkSauce.CheckedChanged += (s, e) => UpdateList();

            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
        }

        private void chk_KeyDown(object sender, KeyEventArgs e)
        {
            Control current = sender as Control;
            Control parent = current.Parent; // 그룹박스

            if (e.KeyCode == Keys.Down)
            {
                parent.SelectNextControl(current, true, true, true, false);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                parent.SelectNextControl(current, false, true, true, false);
                e.Handled = true;
            }
        }

    }
}
