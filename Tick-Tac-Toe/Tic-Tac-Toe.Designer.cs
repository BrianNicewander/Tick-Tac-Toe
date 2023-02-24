namespace Tick_Tac_Toe
{
    partial class Form1
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
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblZeroZero = new System.Windows.Forms.Label();
            this.lblZeroOne = new System.Windows.Forms.Label();
            this.lblZeroTwo = new System.Windows.Forms.Label();
            this.lblOneZero = new System.Windows.Forms.Label();
            this.lblOneOne = new System.Windows.Forms.Label();
            this.lblOneTwo = new System.Windows.Forms.Label();
            this.lblTwoZero = new System.Windows.Forms.Label();
            this.lblTwoOne = new System.Windows.Forms.Label();
            this.lblTwoTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(12, 304);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(321, 28);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(83, 345);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(186, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblZeroZero
            // 
            this.lblZeroZero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZeroZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeroZero.Location = new System.Drawing.Point(12, 9);
            this.lblZeroZero.Name = "lblZeroZero";
            this.lblZeroZero.Size = new System.Drawing.Size(103, 88);
            this.lblZeroZero.TabIndex = 3;
            this.lblZeroZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZeroOne
            // 
            this.lblZeroOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZeroOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeroOne.Location = new System.Drawing.Point(121, 9);
            this.lblZeroOne.Name = "lblZeroOne";
            this.lblZeroOne.Size = new System.Drawing.Size(103, 88);
            this.lblZeroOne.TabIndex = 4;
            this.lblZeroOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZeroTwo
            // 
            this.lblZeroTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZeroTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeroTwo.Location = new System.Drawing.Point(230, 9);
            this.lblZeroTwo.Name = "lblZeroTwo";
            this.lblZeroTwo.Size = new System.Drawing.Size(103, 88);
            this.lblZeroTwo.TabIndex = 5;
            this.lblZeroTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOneZero
            // 
            this.lblOneZero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOneZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneZero.Location = new System.Drawing.Point(12, 106);
            this.lblOneZero.Name = "lblOneZero";
            this.lblOneZero.Size = new System.Drawing.Size(103, 88);
            this.lblOneZero.TabIndex = 6;
            this.lblOneZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOneOne
            // 
            this.lblOneOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOneOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneOne.Location = new System.Drawing.Point(121, 106);
            this.lblOneOne.Name = "lblOneOne";
            this.lblOneOne.Size = new System.Drawing.Size(103, 88);
            this.lblOneOne.TabIndex = 7;
            this.lblOneOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOneTwo
            // 
            this.lblOneTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOneTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneTwo.Location = new System.Drawing.Point(230, 106);
            this.lblOneTwo.Name = "lblOneTwo";
            this.lblOneTwo.Size = new System.Drawing.Size(103, 88);
            this.lblOneTwo.TabIndex = 8;
            this.lblOneTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTwoZero
            // 
            this.lblTwoZero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTwoZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoZero.Location = new System.Drawing.Point(12, 204);
            this.lblTwoZero.Name = "lblTwoZero";
            this.lblTwoZero.Size = new System.Drawing.Size(103, 88);
            this.lblTwoZero.TabIndex = 9;
            this.lblTwoZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTwoOne
            // 
            this.lblTwoOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTwoOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoOne.Location = new System.Drawing.Point(121, 204);
            this.lblTwoOne.Name = "lblTwoOne";
            this.lblTwoOne.Size = new System.Drawing.Size(103, 88);
            this.lblTwoOne.TabIndex = 10;
            this.lblTwoOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTwoTwo
            // 
            this.lblTwoTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTwoTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoTwo.Location = new System.Drawing.Point(230, 204);
            this.lblTwoTwo.Name = "lblTwoTwo";
            this.lblTwoTwo.Size = new System.Drawing.Size(103, 88);
            this.lblTwoTwo.TabIndex = 11;
            this.lblTwoTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 387);
            this.Controls.Add(this.lblTwoTwo);
            this.Controls.Add(this.lblTwoOne);
            this.Controls.Add(this.lblTwoZero);
            this.Controls.Add(this.lblOneTwo);
            this.Controls.Add(this.lblOneOne);
            this.Controls.Add(this.lblOneZero);
            this.Controls.Add(this.lblZeroTwo);
            this.Controls.Add(this.lblZeroOne);
            this.Controls.Add(this.lblZeroZero);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblWinner);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblZeroZero;
        private System.Windows.Forms.Label lblZeroOne;
        private System.Windows.Forms.Label lblZeroTwo;
        private System.Windows.Forms.Label lblOneZero;
        private System.Windows.Forms.Label lblOneOne;
        private System.Windows.Forms.Label lblOneTwo;
        private System.Windows.Forms.Label lblTwoZero;
        private System.Windows.Forms.Label lblTwoOne;
        private System.Windows.Forms.Label lblTwoTwo;
    }
}

