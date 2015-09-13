using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orbit_
{
    public partial class Form1 : Form
    {
        public struct Ball
        {
            public double[] fPos;
            public double[] fVel;
            public double[] fAcc;
            public double fMass;
            public double fDiam;
            public Color cFill;
            public Color cOutline;
            public Boolean bDelete;
            public Boolean bBadPos;
            public Timer tmrBeforeDelete;
            public int iExpired;
            //Constructor
            public Ball(double[] fPos, double[] fVel, double[] fAcc, double fMass, double fDiam, Color cFill, Color cOutline, Boolean bDelete, Boolean bBadPos, Timer tmrBeforeDelete, int iExpired)
            {
                this.fPos = fPos;
                this.fVel = fVel;
                this.fAcc = fAcc;
                this.fMass = fMass;
                this.fDiam = fDiam;
                this.cFill = cFill;
                this.cOutline = cOutline;
                this.bDelete = bDelete;
                this.bBadPos = bBadPos;
                this.tmrBeforeDelete = tmrBeforeDelete;
                this.iExpired = iExpired;
            }
        }
        public struct Force
        {
            public double[] fTotal;
            public double[] fNoise;
            public double[] fRand;
            public double[] fGravity;
            public double[] fOP;
            public double fMagOP;

            public Force(double[] fTotal, double[] fNoise, double[] fRand, double[] fGravity, double[] fOP, double fMagOP)
            {
                this.fTotal = fTotal;
                this.fNoise = fNoise;
                this.fRand = fRand;
                this.fGravity = fGravity;
                this.fMagOP = fMagOP;
                this.fOP = fOP;
            }
        }
        public struct Control
        {
            public DateTime dPLastUpdate;
            public DateTime dVLastUpdate;
            public double fKp;
            public double fKi;
            public double fKd;
            public Boolean bSwtProp;  //Proportional Switch
            public Boolean bSwtInt;   //Integral Switch
            public Boolean bSwtDeriv; //Derivative Switch
            public Control(DateTime dPLastUpdate, DateTime dVLastUpdate, double fKp, double fKi, double fKd, Boolean bSwtProp, Boolean bSwtInt, Boolean bSwtDeriv)
            {
                this.dPLastUpdate = dPLastUpdate;
                this.dVLastUpdate = dPLastUpdate;
                this.fKp = fKp;
                this.fKi = fKi;
                this.fKd = fKd;
                this.bSwtProp = bSwtProp;
                this.bSwtInt = bSwtInt;
                this.bSwtDeriv = bSwtDeriv;
            }
        }
        public struct SysVars
        {
            public double fRandForce;
            public double fOPInc;
            public double fEarthMass;
            public int iFlameW;
            public int iFlameH;
            public int iMushD;
            public SysVars(double fRandForce, double fOPInc, double fEarthMass, int iFlameW, int iFlameH, int iMushD)
            {
                this.fRandForce = fRandForce;
                this.fOPInc = fOPInc;
                this.fEarthMass = fEarthMass;
                this.iFlameW = iFlameW;
                this.iFlameH = iFlameH;
                this.iMushD = iMushD;
            }
        }
        public struct ComBall
        {
            public Ball b;
            public Force f;
            public Control c;
            public ComBall(Ball b, Force f, Control c)
            {
                this.b = b;
                this.f = f;
                this.c = c;
            }
        } //Complete Ball System
        public List<ComBall> myBalls = new List<ComBall>();
        public SysVars mySysVars = new SysVars();


        public static Bitmap bmEarth;
        public static Bitmap bmFlame;
        public static Bitmap bmMush;
        public bool bUpdateLabels;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetVisibilityOfLabels();
            InitializeSysVars();
            pbGalaxy.Dock = DockStyle.Fill;
            pbGalaxy.BackColor = Color.Black;
            pbGalaxy.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGalaxy_Paint);
            int iDiam = 235;
            Ball bTmp = new Ball(new double[2] { 0,0}, new double[2] { 0, 0 }, new double[2] { 0, 0 },mySysVars.fEarthMass, iDiam, Color.Green, Color.Green, false, false, new Timer(), 0);
            Force fTmp = new Force(new double[2] { 0, 0 }, new double[2] { 0, 0 }, new double[2] { 0, 0 }, new double[2] { 0, 0 }, new double[2] { 0, 0 },0);
            Control cTmp = new Control();
            ComBall Earth = new ComBall(bTmp, fTmp, cTmp);
            myBalls.Add(Earth);

            LoadEarthImage();
            LoadFlameImage();
            LoadMushImage();
            tmrDraw.Enabled = true;
        }
        public void SetVisibilityOfLabels()
        {
            lblPosX.Visible = Properties.Settings.Default.bPosition;
            lblPosY.Visible = Properties.Settings.Default.bPosition;
            lblTPos.Visible = Properties.Settings.Default.bPosition;
            lblVelX.Visible = Properties.Settings.Default.bVelocity;
            lblVelY.Visible = Properties.Settings.Default.bVelocity;
            lblVelTotal.Visible = Properties.Settings.Default.bVelocity;
            lblTVel.Visible = Properties.Settings.Default.bVelocity;
            lblAccX.Visible = Properties.Settings.Default.bAcceleration;
            lblAccY.Visible = Properties.Settings.Default.bAcceleration;
            lblAccTotal.Visible = Properties.Settings.Default.bAcceleration;
            lblTAcc.Visible = Properties.Settings.Default.bAcceleration;
            lblForceX.Visible = Properties.Settings.Default.bForce;
            lblForceY.Visible = Properties.Settings.Default.bForce;
            lblForceTotal.Visible = Properties.Settings.Default.bForce;
            lblTForce.Visible = Properties.Settings.Default.bForce;
            lblMouseX.Visible = Properties.Settings.Default.bMousePos;
            lblMouseY.Visible = Properties.Settings.Default.bMousePos;
            lblTMousePos.Visible = Properties.Settings.Default.bMousePos;
            lblFOPX.Visible = Properties.Settings.Default.bForceOP;
            lblFOPY.Visible = Properties.Settings.Default.bForceOP;
            lblFOPT.Visible = Properties.Settings.Default.bForceOP;
            if (Properties.Settings.Default.bPosition||Properties.Settings.Default.bVelocity||Properties.Settings.Default.bAcceleration||Properties.Settings.Default.bForce||Properties.Settings.Default.bMousePos||Properties.Settings.Default.bForceOP)
            {
                bUpdateLabels = true;
            }
            else
            {
                bUpdateLabels = false;
            }
        }
        private void LoadEarthImage()
        {
            TextureBrush TB;
            Image img = Orbit_.Properties.Resources.Earth_from_Space_compressed;
            Bitmap SourceImage;
            SourceImage = new Bitmap(img);
            Rectangle CropRect;
            CropRect = new Rectangle(20, 22, (int)myBalls[0].b.fDiam, (int)myBalls[0].b.fDiam);
            Image croppedImage;
            croppedImage = SourceImage.Clone(CropRect, SourceImage.PixelFormat);
            TB = new TextureBrush(croppedImage);

            bmEarth = new Bitmap((int)myBalls[0].b.fDiam, (int)myBalls[0].b.fDiam);
            Graphics G = Graphics.FromImage(bmEarth);
            //Draw our cropped image onto the output image as an ellipse with the same width/height (circle)
            G.FillEllipse(TB, 0, 0, (int)myBalls[0].b.fDiam, (int)myBalls[0].b.fDiam);
        }
        private void LoadMushImage()
        {
            TextureBrush TB;
            Image img = Orbit_.Properties.Resources.Mush_30_30;
            Bitmap SourceImage;
            SourceImage = new Bitmap(img);
            Rectangle CropRect;
            CropRect = new Rectangle(20, 22, mySysVars.iMushD, mySysVars.iMushD);
            Image croppedImage;
            croppedImage = SourceImage.Clone(CropRect, SourceImage.PixelFormat);
            TB = new TextureBrush(croppedImage);

            bmMush = new Bitmap(mySysVars.iMushD, mySysVars.iMushD);
            Graphics G = Graphics.FromImage(bmEarth);
            //Draw our cropped image onto the output image as an ellipse with the same width/height (circle)
            G.FillEllipse(TB, 0, 0, mySysVars.iMushD, mySysVars.iMushD);

        }
        private void LoadFlameImage()
        {
            Image img = Orbit_.Properties.Resources.flame_20_27;
            Bitmap SourceImage;
            SourceImage = new Bitmap(img);

            bmFlame = new Bitmap(mySysVars.iFlameW,mySysVars.iFlameH);
            Graphics G = Graphics.FromImage(bmFlame);
            G.DrawImage(SourceImage,new Point(0,0));
        }
        private void InitializeSysVars()
        {
            mySysVars.fEarthMass = 1600;
            mySysVars.fOPInc = 1;
            mySysVars.iFlameW = 20;
            mySysVars.iFlameH = 27;
        }
        private void pbGalaxy_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(Color.Red);
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;
            int iXStart;
            int iYStart;
            double dXOffset;
            double dYOffset;
            double dAngle;
            Bitmap bmMushRot;

            for (int i = 0; i < myBalls.Count; i++)
            {
                if (i == 0)
                {
                    iXStart = (int)((myBalls[i].b.fPos[0]) + (pbGalaxy.Width - myBalls[i].b.fDiam) / 2);
                    iYStart = (int)((-myBalls[i].b.fPos[1]) + (pbGalaxy.Height - myBalls[i].b.fDiam) / 2);
                    g.DrawImage(bmEarth, iXStart, iYStart);
                }
                else
                {
                    b = new SolidBrush(myBalls[i].b.cFill);
                    iXStart = (int)((myBalls[i].b.fPos[0]) + (pbGalaxy.Width - myBalls[i].b.fDiam) / 2);
                    iYStart = (int)((-myBalls[i].b.fPos[1]) + (pbGalaxy.Height - myBalls[i].b.fDiam) / 2);
                
                    dAngle = Math.Atan(myBalls[i].b.fPos[0] / myBalls[i].b.fPos[1]);

                    if (myBalls[i].b.fPos[1] < 0)
                    {
                        dAngle -= (Math.PI / 2);
                    }
                    else if (myBalls[i].b.fPos[1] > 0)
                    {
                        dAngle += (Math.PI / 2);
                    }
                    else if (myBalls[i].b.fPos[1] == 0)
                    {
                        dAngle += (Math.PI / 2);
                    }

                    /*if (myBalls[i].b.bBadPos && Properties.Settings.Default.bExplosions)
                    {
                        bmMushRot = RotateImg(bmMush, dAngle * 180 / Math.PI, Color.Transparent);
                        g.DrawImage(bmMushRot, iXStart, iYStart);
                    }
                    else
                    {
                        g.FillEllipse(b, iXStart, iYStart, (int)myBalls[i].b.fDiam, (int)myBalls[i].b.fDiam);
                    }*/
                    g.FillEllipse(b, iXStart, iYStart, (int)myBalls[i].b.fDiam, (int)myBalls[i].b.fDiam);

                    /*
                    dXOffset = 0;
                    dYOffset = 0;
                    double dTotalDist = 0; 
                    if (myBalls[i].b.fPos[1] < 0 && myBalls[i].b.fPos[0] < 0)
                    {
                        dTotalDist = Math.Sqrt(Math.Pow(myBalls[i].b.fPos[0],2)+Math.Pow(myBalls[i].b.fPos[1],2));
                        dXOffset = (myBalls[i].b.fPos[0] / dTotalDist) * myBalls[i].b.fDiam;
                        dYOffset = (myBalls[i].b.fPos[1] / dTotalDist) * myBalls[i].b.fDiam;
                        dAngle -= (Math.PI / 2);
                    }
                    else if (myBalls[i].b.fPos[1] > 0 && myBalls[i].b.fPos[0] < 0)
                    {
                        dTotalDist = Math.Sqrt(Math.Pow(myBalls[i].b.fPos[0], 2) + Math.Pow(myBalls[i].b.fPos[1], 2));
                        dXOffset = -((myBalls[i].b.fPos[0] / dTotalDist) * (myBalls[i].b.fDiam*2));
                        dYOffset = -((myBalls[i].b.fPos[1] / dTotalDist) * (myBalls[i].b.fDiam*2));
                        dAngle += (Math.PI / 2);
                    }
                    else if (myBalls[i].b.fPos[1] > 0 && myBalls[i].b.fPos[0] > 0)
                    {
                        dTotalDist = Math.Sqrt(Math.Pow(myBalls[i].b.fPos[0], 2) + Math.Pow(myBalls[i].b.fPos[1], 2));
                        dXOffset = (myBalls[i].b.fPos[0] / dTotalDist) * myBalls[i].b.fDiam;
                        dYOffset = (myBalls[i].b.fPos[1] / dTotalDist) * myBalls[i].b.fDiam;
                        dAngle += (Math.PI / 2);
                    }
                    else if (myBalls[i].b.fPos[1] < 0 && myBalls[i].b.fPos[0] > 0)
                    {
                        dTotalDist = Math.Sqrt(Math.Pow(myBalls[i].b.fPos[0], 2) + Math.Pow(myBalls[i].b.fPos[1], 2));
                        dXOffset = (myBalls[i].b.fPos[0] / dTotalDist) * myBalls[i].b.fDiam;
                        dYOffset = (myBalls[i].b.fPos[1] / dTotalDist) * myBalls[i].b.fDiam;
                        dAngle -= (Math.PI / 2);
                    }


                    if (myBalls[i].b.fPos[1] == 0 && myBalls[i].b.fPos[0] < 0)
                    {
                        dYOffset = -myBalls[i].b.fDiam;
                        dAngle += (Math.PI / 2);
                    }
                    else if (myBalls[i].b.fPos[1] == 0 && myBalls[i].b.fPos[0] > 0)
                    {
                        dYOffset = myBalls[i].b.fDiam;
                        dAngle += (Math.PI / 2);
                    }
                    else if (myBalls[i].b.fPos[1] > 0 && myBalls[i].b.fPos[0] == 0)
                    {
                        dXOffset = myBalls[i].b.fDiam;
                        dAngle += (Math.PI / 2);
                    }
                    else if (myBalls[i].b.fPos[1] < 0 && myBalls[i].b.fPos[0] == 0)
                    {
                        dXOffset = -myBalls[i].b.fDiam;
                        dAngle -= (Math.PI / 2);
                    }

                    dYOffset = 0;
                    dXOffset = 0;*/

                    //bmFlameRot = RotateImg(bmFlame, dAngle*180/Math.PI, Color.Transparent);


                
                }
            }
           
        }
        public static Bitmap RotateImg(Bitmap bmp, double angle, Color bkColor)
        {
            angle = angle % 360;
            if (angle > 180)
                angle -= 360;

            System.Drawing.Imaging.PixelFormat pf = default(System.Drawing.Imaging.PixelFormat);
            if (bkColor == Color.Transparent)
            {
                pf = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
            }
            else
            {
                pf = bmp.PixelFormat;
            }

            float sin = (float)Math.Abs(Math.Sin(angle * Math.PI / 180.0)); // this function takes radians
            float cos = (float)Math.Abs(Math.Cos(angle * Math.PI / 180.0)); // this one too
            float newImgWidth = sin * bmp.Height + cos * bmp.Width;
            float newImgHeight = sin * bmp.Width + cos * bmp.Height;
            float originX = 0f;
            float originY = 0f;

            if (angle > 0)
            {
                if (angle <= 90)
                    originX = sin * bmp.Height;
                else
                {
                    originX = newImgWidth;
                    originY = newImgHeight - sin * bmp.Width;
                }
            }
            else
            {
                if (angle >= -90)
                    originY = sin * bmp.Width;
                else
                {
                    originX = newImgWidth - sin * bmp.Height;
                    originY = newImgHeight;
                }
            }

            Bitmap newBM = new Bitmap((int)newImgWidth, (int)newImgHeight, pf);
            Graphics g = Graphics.FromImage(newBM);
            g.Clear(bkColor);
            g.TranslateTransform(originX, originY); // offset the origin to our calculated values
            g.RotateTransform((float)angle); // set up rotate
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(bmp, 0, 0); // draw the image at 0, 0
            g.Dispose();

            return newBM;
        }
        private void tmrDraw_Tick(object sender, EventArgs e)
        {
            tmrDraw.Enabled = false;
            for (int i = 1; i < myBalls.Count; i++)
            {
                SetVisibilityOfLabels();
                if (bUpdateLabels)
                {
                    UpdateLabels();
                }
                if (myBalls[i].b.bBadPos == false)
                {

                    UpdateOPForce(i, 0);
                    UpdateForces(myBalls[i]);
                    UpdateAcceleration(myBalls[i]);

                    var v = myBalls[i];
                    UpdateVelocity(ref v);
                    UpdatePosition(ref v);
                    myBalls[i] = v;

                    CheckIfBallsTouch(i);
                }
            }
            PurgeBalls();
            pbGalaxy.Invalidate();
            tmrDraw.Enabled = true;
        }
        private void UpdateLabels()
        {
            Point screenCoordinates = this.PointToScreen(new Point(0, 0));
            lblMouseX.Text = Convert.ToString(MousePosition.X - screenCoordinates.X);
            lblMouseY.Text = Convert.ToString(MousePosition.Y - screenCoordinates.Y);

            lblPosX.Text =(myBalls[myBalls.Count - 1].b.fPos[0]).ToString("N2");
            lblPosY.Text = (myBalls[myBalls.Count - 1].b.fPos[1]).ToString("N2");
            lblVelX.Text = (myBalls[myBalls.Count - 1].b.fVel[0]).ToString("N2");
            lblVelY.Text = (myBalls[myBalls.Count - 1].b.fVel[1]).ToString("N2");
            lblVelTotal.Text = (Math.Sqrt(Math.Pow(myBalls[myBalls.Count - 1].b.fVel[0], 2) + Math.Pow(myBalls[myBalls.Count - 1].b.fVel[1], 2))).ToString("N2");
            lblAccX.Text = (myBalls[myBalls.Count - 1].b.fAcc[0]).ToString("N4");
            lblAccY.Text = (myBalls[myBalls.Count - 1].b.fAcc[1]).ToString("N4");
            lblForceX.Text = (myBalls[myBalls.Count - 1].f.fTotal[0]).ToString("N4");
            lblForceY.Text = (myBalls[myBalls.Count - 1].f.fTotal[1]).ToString("N4");
            lblFOPX.Text = (myBalls[myBalls.Count - 1].f.fOP[0]).ToString("N4");
            lblFOPY.Text = (myBalls[myBalls.Count - 1].f.fOP[1]).ToString("N4");
            lblFOPT.Text = (myBalls[myBalls.Count - 1].f.fMagOP).ToString("N4");
        }
        private void pbGalaxy_Click(object sender, EventArgs e)
        {
            int iDiam = 20;
            Point screenCoordinates = this.PointToScreen(new Point(0, 0));
            Timer tmr = new Timer();

            tmr.Interval = 4000;
            tmr.Tick += new System.EventHandler(this.tmrBeforeDelete_Tick);
            Ball bTmp = new Ball(new double[2] { ((MousePosition.X - screenCoordinates.X) - ((pbGalaxy.Width) / 2)), ((screenCoordinates.Y - MousePosition.Y) + (pbGalaxy.Height / 2))}, new double[2] { 0, 0 }, new double[2] { 0, 0 }, 1, iDiam, Color.White, Color.White, false, false, tmr, 0);
            Force fTmp = new Force(new double[2] { 0, 0 }, new double[2] { 0, 0 }, new double[2] { 0, 0 }, new double[2] { 0, 0 }, new double[2] { 0, 0 }, 0);
            Control cTmp = new Control(System.DateTime.Now, System.DateTime.Now, 0, 0, 0, false, false, false);
            ComBall moon = new ComBall(bTmp, fTmp, cTmp);
            myBalls.Add(moon);
        }

        // Start Update Ball Movement
        private void UpdateRandomForce()
        {
            Random r = new Random();
            double d;
            d = r.Next(-500, 500);
            mySysVars.fRandForce = d / 1000;
        }
        private void UpdateForces(ComBall cb)
        {
            UpdateGravityForce(cb);
            for (int i = 0; i < cb.f.fTotal.Count(); i++)
            {
                cb.f.fTotal[i] = cb.f.fGravity[i] + cb.f.fOP[i];
            }
        }
        private void UpdateOPForce(int iMoon, double iMagInc)
        {
            double dDiffT;
            double dDiffX;
            double dDiffY;
            double dAngle;
            double dFT;
            double dFY;
            double dFX;
            Ball Planet;
            ComBall Moon;

            Moon = myBalls[iMoon];
            Planet = myBalls[0].b;
            Moon.f.fMagOP += iMagInc;

            dDiffX = Planet.fPos[0] - Moon.b.fPos[0];
            dDiffY = Planet.fPos[1] - Moon.b.fPos[1];

            dDiffT = Math.Sqrt(Math.Pow(dDiffX, 2) + Math.Pow(dDiffY, 2));
            dAngle = Math.Atan(dDiffX / dDiffY);

            if (dDiffY < 0)
            {
                dAngle -= (Math.PI / 2);
            }
            else if (dDiffY > 0)
            {
                dAngle += (Math.PI / 2);
            }
            else if (dDiffY == 0)
            {
                dAngle += (Math.PI / 2);
            }
            dFT = Moon.f.fMagOP;
            dFX = dFT * Math.Sin(dAngle);
            dFY = dFT * Math.Cos(dAngle);

            Moon.f.fOP[0] = dFX;
            Moon.f.fOP[1] = dFY;
            myBalls[iMoon] = Moon;
        }
        private void UpdateGravityForce(ComBall cb)
        {
            double dDiffT;
            double dDiffX;
            double dDiffY;
            double dAngle;
            double dFT;
            double dFY;
            double dFX;
            Ball Planet = myBalls[0].b;
            ComBall Moon = cb;

            dDiffX = Planet.fPos[0] - Moon.b.fPos[0];
            dDiffY = Planet.fPos[1] - Moon.b.fPos[1];

            dDiffT = Math.Sqrt(Math.Pow(dDiffX, 2) + Math.Pow(dDiffY, 2));
            dAngle = Math.Atan(dDiffX / dDiffY);

            dFT = (Planet.fMass * Moon.b.fMass) / dDiffT;

            dFX = dFT * Math.Sin(dAngle);
            dFY = dFT * Math.Cos(dAngle);

            if (dDiffX < 0 && dDiffY < 0)
            {
                dFX = -(dFT * Math.Sin(dAngle));
                dFY = -(dFT * Math.Cos(dAngle));
            } 
            else if (dDiffX > 0 && dDiffY < 0)
            {
                dFX = -(dFT * Math.Sin(dAngle));
                dFY = -(dFT * Math.Cos(dAngle));
            } 
            else if (dDiffX > 0 && dDiffY > 0)
            {
                dFX = dFT * Math.Sin(dAngle);
                dFY = dFT * Math.Cos(dAngle);
            } 
            else if (dDiffX < 0 && dDiffY > 0)
            {
                dFX = dFT * Math.Sin(dAngle);
                dFY = dFT * Math.Cos(dAngle);
            }


            if (dDiffX == 0 && dDiffY < 0)
            {
                dFX = 0;
                dFY = -(dFT * Math.Cos(dAngle));
            }
            else if (dDiffX == 0 && dDiffY > 0)
            {
                dFX = 0;
                dFY = dFT * Math.Cos(dAngle);
            }
            else if (dDiffX > 0 && dDiffY ==0)
            {
                dFX = dFT * Math.Sin(dAngle);
                dFY = 0;
            }
            else if (dDiffX < 0 && dDiffY == 0)
            {
                dFX = dFT * Math.Sin(dAngle);
                dFY = 0;
            }
                 

            cb.f.fGravity[0] = dFX;
            cb.f.fGravity[1] = dFY;        
        }
        private void UpdateAcceleration(ComBall cb)
        {
            //a = F/m
            cb.b.fAcc[0] = cb.f.fTotal[0] / cb.b.fMass;
            cb.b.fAcc[1] = cb.f.fTotal[1] / cb.b.fMass;
        }
        private void UpdateVelocity(ref ComBall cb)
        {
            double fmSElapsed;

            TimeSpan dTimeElapsed;
            if (cb.c.dVLastUpdate != new DateTime())
            {
                dTimeElapsed = System.DateTime.Now.Subtract(cb.c.dVLastUpdate);
                fmSElapsed = dTimeElapsed.Milliseconds + (dTimeElapsed.Seconds * 1000);
                cb.b.fVel[0] += (fmSElapsed * cb.b.fAcc[0]) / 1000;
                cb.b.fVel[1] += (fmSElapsed * cb.b.fAcc[1]) / 1000;
            }
            cb.c.dVLastUpdate = System.DateTime.Now;
        }
        private void UpdatePosition(ref ComBall cb)
        {
            double fmSElapsed;
            TimeSpan dTimeElapsed;

            if (cb.c.dPLastUpdate != new DateTime())
            {
                dTimeElapsed = System.DateTime.Now.Subtract(cb.c.dPLastUpdate);
                fmSElapsed = dTimeElapsed.Milliseconds + (dTimeElapsed.Seconds) * 1000;
                cb.b.fPos[0] += (fmSElapsed * cb.b.fVel[0]) / 1000;
                cb.b.fPos[1] += (fmSElapsed * cb.b.fVel[1]) / 1000;
            }
            cb.c.dPLastUpdate = System.DateTime.Now;
        }
        // End Update Ball Movement

        // Start Handle Bad Balls
        private void CheckIfBallsTouch(int iMoon)
        {   
            double dDist;
            int iMaxEx;
            Ball Planet;
            ComBall Moon;

            Planet = myBalls[0].b;
            Moon = myBalls[iMoon];
            if (!Moon.b.bBadPos)
            {
                dDist = Math.Sqrt(Math.Pow(Planet.fPos[0] - Moon.b.fPos[0], 2) + Math.Pow(Planet.fPos[1] - Moon.b.fPos[1], 2));
                if (dDist < (Planet.fDiam + Moon.b.fDiam)/2)
                {
                    Moon.b.cFill = Color.Red;
                    Moon.b.bBadPos = true;
                    HaltBall(Moon.b);
                }
            }
            if (Moon.b.bBadPos)
            {
                iMaxEx = 0;
                for (int i2 = 1; i2 < myBalls.Count; i2++)
                {
                    if (myBalls[i2].b.iExpired > iMaxEx)
                    {
                        iMaxEx = myBalls[i2].b.iExpired;
                    }
                }
                if (Moon.b.iExpired == 0)
                {
                    Moon.b.iExpired = iMaxEx + 1;
                    Moon.b.tmrBeforeDelete.Enabled = true;
                }
            }
            myBalls[iMoon] = Moon;
        }
        private void HaltBall(Ball b)
        {
            for (int i = 0; i < b.fAcc.Length; i++)
            {
                b.fAcc[i] = 0;
                b.fVel[i] = 0;
            }
        }
        private void PurgeBalls()
        {
            List<ComBall> lstComBalls = new List<ComBall>();

            for (int i = 0; i < myBalls.Count; i++)
            {
                if (myBalls[i].b.bDelete == false)
                {
                    lstComBalls.Add(myBalls[i]);
                }
            }
            myBalls = lstComBalls;
        }
        private void tmrBeforeDelete_Tick(Object sender, EventArgs e)
        {
            ComBall ballTemp;
            for (int i = 0; i < myBalls.Count; i++)
            {
                if (myBalls[i].b.iExpired == 1)
                {
                    ballTemp = myBalls[i];
                    ballTemp.b.bDelete = true;
                    ballTemp.b.tmrBeforeDelete.Enabled = false;
                    myBalls[i] = ballTemp;
                }
                else if (myBalls[i].b.iExpired > 1)
                {
                    ballTemp = myBalls[i];
                    ballTemp.b.iExpired -= 1;
                    myBalls[i] = ballTemp;
                }
            }
        }
        // End Handle Bad Balls

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            
            
            switch (c)
            {
                case 'w':
                    if (myBalls.Count > 1)
                    {
                        UpdateOPForce(myBalls.Count - 1, mySysVars.fOPInc);
                    }
                    break;
                /*case 'a':
                    UpdateOPForce(myBalls[myBalls.Count - 1], -1, 0);
                    break;*/
                case 's':
                    if (myBalls.Count > 1)
                    {                    
                        UpdateOPForce(myBalls.Count - 1, -mySysVars.fOPInc);
                    }
                    break;
                /* case 'd':
                        UpdateOPForce(myBalls[myBalls.Count - 1], 1, 0);
                        break;*/
                case 'm':
                    menuStrip1.Visible = !menuStrip1.Visible;
                    break;

               }
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fSettings fs = new fSettings();
            fs.Show();
        }
    }
}
