namespace Calculator.WinForms
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCalculateAdd_Click = new System.Windows.Forms.Button();
            this.btnCalculateDiv_Click = new System.Windows.Forms.Button();
            this.btnCalculatePow_Click = new System.Windows.Forms.Button();
            this.btnCalculateMult_Click = new System.Windows.Forms.Button();
            this.btnCalculateSub_Click = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 557);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCalculateAdd_Click);
            this.tabPage1.Controls.Add(this.btnCalculateDiv_Click);
            this.tabPage1.Controls.Add(this.btnCalculatePow_Click);
            this.tabPage1.Controls.Add(this.btnCalculateMult_Click);
            this.tabPage1.Controls.Add(this.btnCalculateSub_Click);
            this.tabPage1.Controls.Add(this.txtResult);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtNum2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNum1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCalculateAdd_Click
            // 
            this.btnCalculateAdd_Click.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculateAdd_Click.Location = new System.Drawing.Point(9, 339);
            this.btnCalculateAdd_Click.Name = "btnCalculateAdd_Click";
            this.btnCalculateAdd_Click.Size = new System.Drawing.Size(125, 46);
            this.btnCalculateAdd_Click.TabIndex = 12;
            this.btnCalculateAdd_Click.Text = "Add";
            this.btnCalculateAdd_Click.UseVisualStyleBackColor = true;
            this.btnCalculateAdd_Click.Click += new System.EventHandler(this.btnClickAdd_Click);
            // 
            // btnCalculateDiv_Click
            // 
            this.btnCalculateDiv_Click.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculateDiv_Click.Location = new System.Drawing.Point(402, 339);
            this.btnCalculateDiv_Click.Name = "btnCalculateDiv_Click";
            this.btnCalculateDiv_Click.Size = new System.Drawing.Size(125, 46);
            this.btnCalculateDiv_Click.TabIndex = 11;
            this.btnCalculateDiv_Click.Text = "Divide";
            this.btnCalculateDiv_Click.UseVisualStyleBackColor = true;
            this.btnCalculateDiv_Click.Click += new System.EventHandler(this.btnCalculateDiv_Click_Click);
            // 
            // btnCalculatePow_Click
            // 
            this.btnCalculatePow_Click.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculatePow_Click.Location = new System.Drawing.Point(533, 339);
            this.btnCalculatePow_Click.Name = "btnCalculatePow_Click";
            this.btnCalculatePow_Click.Size = new System.Drawing.Size(125, 46);
            this.btnCalculatePow_Click.TabIndex = 10;
            this.btnCalculatePow_Click.Text = "Power";
            this.btnCalculatePow_Click.UseVisualStyleBackColor = true;
            this.btnCalculatePow_Click.Click += new System.EventHandler(this.btnCalculatePow_Click_Click);
            // 
            // btnCalculateMult_Click
            // 
            this.btnCalculateMult_Click.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculateMult_Click.Location = new System.Drawing.Point(271, 339);
            this.btnCalculateMult_Click.Name = "btnCalculateMult_Click";
            this.btnCalculateMult_Click.Size = new System.Drawing.Size(125, 46);
            this.btnCalculateMult_Click.TabIndex = 8;
            this.btnCalculateMult_Click.Text = "Multiply";
            this.btnCalculateMult_Click.UseVisualStyleBackColor = true;
            this.btnCalculateMult_Click.Click += new System.EventHandler(this.btnCalculateMult_Click_Click);
            // 
            // btnCalculateSub_Click
            // 
            this.btnCalculateSub_Click.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculateSub_Click.Location = new System.Drawing.Point(140, 339);
            this.btnCalculateSub_Click.Name = "btnCalculateSub_Click";
            this.btnCalculateSub_Click.Size = new System.Drawing.Size(125, 46);
            this.btnCalculateSub_Click.TabIndex = 7;
            this.btnCalculateSub_Click.Text = "Subtract";
            this.btnCalculateSub_Click.UseVisualStyleBackColor = true;
            this.btnCalculateSub_Click.Click += new System.EventHandler(this.btnCalculateSub_Click_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(533, 207);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(125, 43);
            this.txtResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(533, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(271, 207);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(125, 43);
            this.txtNum2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(271, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Number";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(9, 207);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(125, 43);
            this.txtNum1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNumber,
            this.secondNumber,
            this.action});
            this.dataGridView1.Location = new System.Drawing.Point(-4, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(769, 387);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // firstNumber
            // 
            this.firstNumber.HeaderText = "First Number";
            this.firstNumber.MinimumWidth = 10;
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.firstNumber.Width = 200;
            // 
            // secondNumber
            // 
            this.secondNumber.HeaderText = "Second Number";
            this.secondNumber.MinimumWidth = 10;
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.secondNumber.Width = 200;
            // 
            // action
            // 
            this.action.HeaderText = "Result";
            this.action.MinimumWidth = 10;
            this.action.Name = "action";
            this.action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.action.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 680);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculateSub_Click;
        private System.Windows.Forms.Button btnCalculateMult_Click;
        private System.Windows.Forms.Button btnCalculatePow_Click;
        private System.Windows.Forms.Button btnCalculateDiv_Click;
        private System.Windows.Forms.Button btnCalculateAdd_Click;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        // private System.Windows.Forms.Button btnCalculateAdd_Click;
    }
}

