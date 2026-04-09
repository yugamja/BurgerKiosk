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
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rdo_ChickenBurger = new RadioButton();
            rdo_BulgogiBurger = new RadioButton();
            rdo_HamBurger = new RadioButton();
            groupBox2 = new GroupBox();
            chk_source = new CheckBox();
            chk_cheese = new CheckBox();
            chk_coke = new CheckBox();
            chk_potapo = new CheckBox();
            groupBox3 = new GroupBox();
            lbl_total = new Label();
            list_order = new ListBox();
            btn_order = new Button();
            btn_reset = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rdo_ChickenBurger);
            groupBox1.Controls.Add(rdo_BulgogiBurger);
            groupBox1.Controls.Add(rdo_HamBurger);
            groupBox1.Font = new Font("궁서", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.ForeColor = Color.DarkOliveGreen;
            groupBox1.Location = new Point(27, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 310);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴 선택";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(174, 215);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(105, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(174, 137);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // rdo_ChickenBurger
            // 
            rdo_ChickenBurger.AutoSize = true;
            rdo_ChickenBurger.Font = new Font("궁서", 10F, FontStyle.Bold);
            rdo_ChickenBurger.ForeColor = Color.Black;
            rdo_ChickenBurger.Location = new Point(25, 240);
            rdo_ChickenBurger.Name = "rdo_ChickenBurger";
            rdo_ChickenBurger.Size = new Size(118, 24);
            rdo_ChickenBurger.TabIndex = 2;
            rdo_ChickenBurger.TabStop = true;
            rdo_ChickenBurger.Text = "치킨버거";
            rdo_ChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdo_BulgogiBurger
            // 
            rdo_BulgogiBurger.AutoSize = true;
            rdo_BulgogiBurger.Font = new Font("궁서", 10F, FontStyle.Bold);
            rdo_BulgogiBurger.ForeColor = Color.Black;
            rdo_BulgogiBurger.Location = new Point(25, 163);
            rdo_BulgogiBurger.Name = "rdo_BulgogiBurger";
            rdo_BulgogiBurger.Size = new Size(139, 24);
            rdo_BulgogiBurger.TabIndex = 1;
            rdo_BulgogiBurger.TabStop = true;
            rdo_BulgogiBurger.Text = "불고기버거";
            rdo_BulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdo_HamBurger
            // 
            rdo_HamBurger.AutoSize = true;
            rdo_HamBurger.Font = new Font("궁서", 10F, FontStyle.Bold);
            rdo_HamBurger.ForeColor = Color.Black;
            rdo_HamBurger.Location = new Point(25, 85);
            rdo_HamBurger.Name = "rdo_HamBurger";
            rdo_HamBurger.Size = new Size(97, 24);
            rdo_HamBurger.TabIndex = 0;
            rdo_HamBurger.TabStop = true;
            rdo_HamBurger.Text = "햄버거";
            rdo_HamBurger.TextAlign = ContentAlignment.MiddleCenter;
            rdo_HamBurger.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chk_source);
            groupBox2.Controls.Add(chk_cheese);
            groupBox2.Controls.Add(chk_coke);
            groupBox2.Controls.Add(chk_potapo);
            groupBox2.Font = new Font("궁서", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox2.ForeColor = Color.DarkOliveGreen;
            groupBox2.Location = new Point(355, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(188, 225);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "추가 옵션";
            // 
            // chk_source
            // 
            chk_source.AutoSize = true;
            chk_source.Font = new Font("궁서", 10F, FontStyle.Bold);
            chk_source.ForeColor = Color.Black;
            chk_source.Location = new Point(6, 171);
            chk_source.Name = "chk_source";
            chk_source.Size = new Size(127, 24);
            chk_source.TabIndex = 4;
            chk_source.Text = "소스 추가";
            chk_source.UseVisualStyleBackColor = true;
            // 
            // chk_cheese
            // 
            chk_cheese.AutoSize = true;
            chk_cheese.Font = new Font("궁서", 10F, FontStyle.Bold);
            chk_cheese.ForeColor = Color.Black;
            chk_cheese.Location = new Point(6, 127);
            chk_cheese.Name = "chk_cheese";
            chk_cheese.Size = new Size(127, 24);
            chk_cheese.TabIndex = 3;
            chk_cheese.Text = "치즈 추가";
            chk_cheese.UseVisualStyleBackColor = true;
            // 
            // chk_coke
            // 
            chk_coke.AutoSize = true;
            chk_coke.Font = new Font("궁서", 10F, FontStyle.Bold);
            chk_coke.ForeColor = Color.Black;
            chk_coke.Location = new Point(6, 85);
            chk_coke.Name = "chk_coke";
            chk_coke.Size = new Size(77, 24);
            chk_coke.TabIndex = 2;
            chk_coke.Text = "콜라";
            chk_coke.UseVisualStyleBackColor = true;
            // 
            // chk_potapo
            // 
            chk_potapo.AutoSize = true;
            chk_potapo.Font = new Font("궁서", 10F, FontStyle.Bold);
            chk_potapo.ForeColor = Color.Black;
            chk_potapo.Location = new Point(6, 43);
            chk_potapo.Name = "chk_potapo";
            chk_potapo.Size = new Size(119, 24);
            chk_potapo.TabIndex = 0;
            chk_potapo.Text = "감자튀김";
            chk_potapo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl_total);
            groupBox3.Controls.Add(list_order);
            groupBox3.Font = new Font("궁서", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox3.ForeColor = Color.DarkOliveGreen;
            groupBox3.Location = new Point(573, 98);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(262, 257);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문 내역";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Font = new Font("맑은 고딕", 12F);
            lbl_total.ForeColor = Color.Blue;
            lbl_total.Location = new Point(20, 215);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(152, 32);
            lbl_total.TabIndex = 1;
            lbl_total.Text = "총 금액 : 0원";
            // 
            // list_order
            // 
            list_order.Font = new Font("맑은 고딕", 12F);
            list_order.ForeColor = Color.Blue;
            list_order.FormattingEnabled = true;
            list_order.Location = new Point(20, 43);
            list_order.Name = "list_order";
            list_order.Size = new Size(224, 164);
            list_order.TabIndex = 0;
            // 
            // btn_order
            // 
            btn_order.BackColor = Color.SeaGreen;
            btn_order.Font = new Font("궁서", 11F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn_order.ForeColor = Color.White;
            btn_order.Location = new Point(573, 374);
            btn_order.Name = "btn_order";
            btn_order.Size = new Size(126, 48);
            btn_order.TabIndex = 4;
            btn_order.Text = "주문하기";
            btn_order.UseVisualStyleBackColor = false;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.OrangeRed;
            btn_reset.Font = new Font("궁서", 11F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn_reset.ForeColor = Color.White;
            btn_reset.Location = new Point(705, 374);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(130, 48);
            btn_reset.TabIndex = 5;
            btn_reset.Text = "초기화";
            btn_reset.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(878, 472);
            Controls.Add(btn_reset);
            Controls.Add(btn_order);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Burger Kiosk";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chk_cheese;
        private CheckBox chk_coke;
        private CheckBox chk_potapo;
        private GroupBox groupBox3;
        private ListBox list_order;
        private Label lbl_total;
        private Button btn_order;
        private Button btn_reset;
        private CheckBox chk_source;
        private RadioButton rdo_ChickenBurger;
        private RadioButton rdo_BulgogiBurger;
        private RadioButton rdo_HamBurger;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
