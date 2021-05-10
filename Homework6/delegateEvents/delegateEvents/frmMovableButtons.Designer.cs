namespace Advanced_CSharp_exercises
{
    partial class frmMovableButtons
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMovement = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnMoveHome = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovement)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMoveHome);
            this.groupBox1.Controls.Add(this.btnMove);
            this.groupBox1.Controls.Add(this.nudMovement);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // nudMovement
            // 
            this.nudMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMovement.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMovement.Location = new System.Drawing.Point(116, 26);
            this.nudMovement.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMovement.Name = "nudMovement";
            this.nudMovement.Size = new System.Drawing.Size(56, 23);
            this.nudMovement.TabIndex = 1;
            this.nudMovement.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movement:";
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(93, 63);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "Random button";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(20, 67);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(164, 34);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "From current position";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnMoveHome
            // 
            this.btnMoveHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveHome.Location = new System.Drawing.Point(196, 67);
            this.btnMoveHome.Name = "btnMoveHome";
            this.btnMoveHome.Size = new System.Drawing.Size(164, 34);
            this.btnMoveHome.TabIndex = 3;
            this.btnMoveHome.Text = "From top left";
            this.btnMoveHome.UseVisualStyleBackColor = true;
            this.btnMoveHome.Click += new System.EventHandler(this.btnMoveHome_Click);
            // 
            // frmMovableButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 251);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMovableButtons";
            this.Text = "Movable buttons form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudMovement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnMoveHome;
    }
}