namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInfoEmployee = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnInfoMenu = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInfoEmployee
            // 
            this.btnInfoEmployee.Location = new System.Drawing.Point(122, 84);
            this.btnInfoEmployee.Name = "btnInfoEmployee";
            this.btnInfoEmployee.Size = new System.Drawing.Size(158, 108);
            this.btnInfoEmployee.TabIndex = 0;
            this.btnInfoEmployee.Text = "Thông tin Nhân VIên";
            this.btnInfoEmployee.UseVisualStyleBackColor = true;
            this.btnInfoEmployee.Click += new System.EventHandler(this.btnInfoEmployee_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(377, 84);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(158, 108);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Bán Hàng";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnInfoMenu
            // 
            this.btnInfoMenu.Location = new System.Drawing.Point(122, 226);
            this.btnInfoMenu.Name = "btnInfoMenu";
            this.btnInfoMenu.Size = new System.Drawing.Size(158, 108);
            this.btnInfoMenu.TabIndex = 2;
            this.btnInfoMenu.Text = "Danh sách Đồ Uống";
            this.btnInfoMenu.UseVisualStyleBackColor = true;
            this.btnInfoMenu.Click += new System.EventHandler(this.btnInfoMenu_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Location = new System.Drawing.Point(377, 226);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(158, 108);
            this.btnDashBoard.TabIndex = 3;
            this.btnDashBoard.Text = "Danh Thu";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 421);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.btnInfoMenu);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnInfoEmployee);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfoEmployee;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnInfoMenu;
        private System.Windows.Forms.Button btnDashBoard;
    }
}