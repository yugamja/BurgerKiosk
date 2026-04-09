namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gbo_menu = new GroupBox();
            pic_ChickenBurger = new PictureBox();
            pic_BulgogiBurger = new PictureBox();
            pic_HamBurger = new PictureBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            gbo_option = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            gbo_receipt = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btn_order = new Button();
            btn_reset = new Button();
            lbl_AppName = new Label();
            gbo_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ChickenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_BulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_HamBurger).BeginInit();
            gbo_option.SuspendLayout();
            gbo_receipt.SuspendLayout();
            SuspendLayout();
            // 
            // gbo_menu
            // 
            gbo_menu.Controls.Add(pic_ChickenBurger);
            gbo_menu.Controls.Add(pic_BulgogiBurger);
            gbo_menu.Controls.Add(pic_HamBurger);
            gbo_menu.Controls.Add(rdoChickenBurger);
            gbo_menu.Controls.Add(rdoBulgogiBurger);
            gbo_menu.Controls.Add(rdoHamBurger);
            gbo_menu.Font = new Font("궁서", 12F, FontStyle.Bold | FontStyle.Italic);
            gbo_menu.ForeColor = Color.DarkOliveGreen;
            gbo_menu.Location = new Point(27, 98);
            gbo_menu.Name = "gbo_menu";
            gbo_menu.Size = new Size(302, 310);
            gbo_menu.TabIndex = 1;
            gbo_menu.TabStop = false;
            gbo_menu.Text = "메뉴 선택";
            // 
            // pic_ChickenBurger
            // 
            pic_ChickenBurger.Image = (Image)resources.GetObject("pic_ChickenBurger.Image");
            pic_ChickenBurger.Location = new Point(174, 215);
            pic_ChickenBurger.Name = "pic_ChickenBurger";
            pic_ChickenBurger.Size = new Size(105, 75);
            pic_ChickenBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_ChickenBurger.TabIndex = 5;
            pic_ChickenBurger.TabStop = false;
            // 
            // pic_BulgogiBurger
            // 
            pic_BulgogiBurger.Image = (Image)resources.GetObject("pic_BulgogiBurger.Image");
            pic_BulgogiBurger.Location = new Point(174, 137);
            pic_BulgogiBurger.Name = "pic_BulgogiBurger";
            pic_BulgogiBurger.Size = new Size(105, 75);
            pic_BulgogiBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_BulgogiBurger.TabIndex = 4;
            pic_BulgogiBurger.TabStop = false;
            // 
            // pic_HamBurger
            // 
            pic_HamBurger.Image = (Image)resources.GetObject("pic_HamBurger.Image");
            pic_HamBurger.Location = new Point(174, 56);
            pic_HamBurger.Name = "pic_HamBurger";
            pic_HamBurger.Size = new Size(105, 75);
            pic_HamBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_HamBurger.TabIndex = 3;
            pic_HamBurger.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("궁서", 10F, FontStyle.Bold);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(29, 224);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(118, 24);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("궁서", 10F, FontStyle.Bold);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(29, 147);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(139, 24);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("궁서", 10F, FontStyle.Bold);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(29, 69);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(97, 24);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.TextAlign = ContentAlignment.MiddleCenter;
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // gbo_option
            // 
            gbo_option.Controls.Add(chkSauce);
            gbo_option.Controls.Add(chkCheese);
            gbo_option.Controls.Add(chkCola);
            gbo_option.Controls.Add(chkPotato);
            gbo_option.Font = new Font("궁서", 12F, FontStyle.Bold | FontStyle.Italic);
            gbo_option.ForeColor = Color.DarkOliveGreen;
            gbo_option.Location = new Point(355, 98);
            gbo_option.Name = "gbo_option";
            gbo_option.Size = new Size(188, 225);
            gbo_option.TabIndex = 2;
            gbo_option.TabStop = false;
            gbo_option.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("궁서", 10F, FontStyle.Bold);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(6, 171);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(127, 24);
            chkSauce.TabIndex = 4;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("궁서", 10F, FontStyle.Bold);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(6, 127);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(127, 24);
            chkCheese.TabIndex = 3;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("궁서", 10F, FontStyle.Bold);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(6, 85);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(77, 24);
            chkCola.TabIndex = 2;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("궁서", 10F, FontStyle.Bold);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(6, 43);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(119, 24);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // gbo_receipt
            // 
            gbo_receipt.Controls.Add(lblTotalCost);
            gbo_receipt.Controls.Add(lstOrder);
            gbo_receipt.Font = new Font("궁서", 12F, FontStyle.Bold | FontStyle.Italic);
            gbo_receipt.ForeColor = Color.DarkOliveGreen;
            gbo_receipt.Location = new Point(573, 98);
            gbo_receipt.Name = "gbo_receipt";
            gbo_receipt.Size = new Size(262, 257);
            gbo_receipt.TabIndex = 0;
            gbo_receipt.TabStop = false;
            gbo_receipt.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 12F);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(20, 215);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(152, 32);
            lblTotalCost.TabIndex = 0;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 12F);
            lstOrder.ForeColor = Color.Blue;
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(20, 43);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(224, 164);
            lstOrder.TabIndex = 0;
            // 
            // btn_order
            // 
            btn_order.BackColor = Color.SeaGreen;
            btn_order.Font = new Font("궁서", 11F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn_order.ForeColor = Color.White;
            btn_order.Location = new Point(573, 373);
            btn_order.Name = "btn_order";
            btn_order.Size = new Size(126, 48);
            btn_order.TabIndex = 0;
            btn_order.Text = "주문하기";
            btn_order.UseVisualStyleBackColor = false;
            btn_order.Click += btn_order_Click;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.OrangeRed;
            btn_reset.Font = new Font("궁서", 11F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn_reset.ForeColor = Color.White;
            btn_reset.Location = new Point(705, 373);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(130, 48);
            btn_reset.TabIndex = 0;
            btn_reset.Text = "초기화";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            // 
            // lbl_AppName
            // 
            lbl_AppName.AutoSize = true;
            lbl_AppName.Font = new Font("궁서", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            lbl_AppName.ForeColor = Color.SaddleBrown;
            lbl_AppName.Location = new Point(27, 29);
            lbl_AppName.Name = "lbl_AppName";
            lbl_AppName.Size = new Size(373, 40);
            lbl_AppName.TabIndex = 0;
            lbl_AppName.Text = "버거 주문 키오스크";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(878, 471);
            Controls.Add(btn_reset);
            Controls.Add(btn_order);
            Controls.Add(gbo_receipt);
            Controls.Add(gbo_option);
            Controls.Add(gbo_menu);
            Controls.Add(lbl_AppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            Load += Form1_Load;
            gbo_menu.ResumeLayout(false);
            gbo_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ChickenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_BulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_HamBurger).EndInit();
            gbo_option.ResumeLayout(false);
            gbo_option.PerformLayout();
            gbo_receipt.ResumeLayout(false);
            gbo_receipt.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbo_menu;
        private GroupBox gbo_option;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkPotato;
        private GroupBox gbo_receipt;
        private ListBox lstOrder;
        private Label lblTotalCost;
        private Button btn_order;
        private Button btn_reset;
        private CheckBox chkSauce;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoHamBurger;
        private PictureBox pic_ChickenBurger;
        private PictureBox pic_BulgogiBurger;
        private PictureBox pic_HamBurger;
        private Label lbl_AppName;
    }
}
