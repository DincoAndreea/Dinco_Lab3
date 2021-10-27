using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.IO;

/// <summary>
/// Lab 3 - Problema 5
/// </summary>

namespace Dinco
{
    class ImmediateMode: GameWindow
    {

        double v1_r = 187 / 255f;
        double v1_g = 125 / 255f;
        double v1_b = 87 / 255f;
        double v1_a = 100 / 255f;

        double v2_r = 189 / 255f;
        double v2_g = 127 / 255f;
        double v2_b = 235 / 255f;
        double v2_a = 198 / 255f;

        double v3_r = 212 / 255f;
        double v3_g = 199 / 255f;
        double v3_b = 56 / 255f;
        double v3_a = 35 / 255f;

        private int x = 0;
        private int y = 0;
        private int z = 0;


        
        public ImmediateMode() : base(800, 600)
        {
            VSync = VSyncMode.On;

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color.DeepPink);

        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            KeyboardState keyboard = Keyboard.GetState();
            MouseState mouse = Mouse.GetState();

            //Console.Clear();

            ///Problema 9

            Console.WriteLine("Valori RGB:\n");
            Console.WriteLine("Vertex 1: (" + Math.Round(v1_r * 255) + ", " + Math.Round(v1_g * 255) + ", " + Math.Round(v1_b * 255) + ", " + Math.Round(v1_a * 255) + ")");
            Console.WriteLine("Vertex 2: (" + Math.Round(v2_r * 255) + ", " + Math.Round(v2_g * 255) + ", " + Math.Round(v2_b * 255) + ", " + Math.Round(v2_a * 255) + ")");
            Console.WriteLine("Vertex 3: (" + Math.Round(v3_r * 255) + ", " + Math.Round(v3_g * 255) + ", " + Math.Round(v3_b * 255) + ", " + Math.Round(v3_a * 255) + ")");

            //Console.ReadKey();

            double counter1 = 1 / 255f;

            
            ///Lab 3 - Problema 8

            ///Vertex 1
            ///Vertex 1 Canal R

            if (keyboard[Key.W] && (v1_r >= -0.02f && v1_r <= 1.01f))
            {
                if(Math.Round(v1_r * 255) > 255)
                {
                    v1_r = 1.00f;
                }

                if ((v1_r * 255) < 0)
                {
                    v1_r = 0;
                }
                v1_r += counter1;
            }

            if (keyboard[Key.Q] && (v1_r >= -0.02f && v1_r <= 1.01f))
            {
                if (Math.Round(v1_r * 255) > 255)
                {
                    v1_r = 1.00f;
                }

                if (v1_r < 0)
                {
                    v1_r = 0;
                }
                v1_r -= counter1;
            }

            ///Vertex 1 Canal G

            if (keyboard[Key.S] && (v1_g >= -0.02f && v1_g <= 1.01f))
            {
                if (Math.Round(v1_g * 255) > 255)
                {
                    v1_g = 1.00f;
                }

                if (v1_g < 0)
                {
                    v1_g = 0;
                }
                v1_g += counter1;
            }

            if (keyboard[Key.A] && (v1_g >= -0.02f && v1_g <= 1.01f))
            {
                if (Math.Round(v1_g * 255) > 255)
                {
                    v1_g = 1.00f;
                }

                if (v1_g < 0)
                {
                    v1_g = 0;
                }
                v1_g -= counter1;
            }

            ///Vertex 1 Canal B

            if (keyboard[Key.X] && (v1_b >= -0.02f && v1_b <= 1.01f))
            {
                if (Math.Round(v1_b * 255) > 255)
                {
                    v1_b = 1.00f;
                }

                if (v1_b < 0)
                {
                    v1_b = 0;
                }
                v1_b += counter1;
            }

            if (keyboard[Key.Z] && (v1_b >= -0.02f && v1_b <= 1.01f))
            {
                if (Math.Round(v1_b * 255) > 255)
                {
                    v1_b = 1.00f;
                }

                if (v1_b < 0)
                {
                    v1_b = 0;
                }
                v1_b -= counter1;
            }

            ///Vertex 1 Canal A

            if (keyboard[Key.Number2] && (v1_a >= -0.02f && v1_a <= 1.01f))
            {
                if (Math.Round(v1_b * 255) > 255)
                {
                    v1_b = 1.00f;
                }

                if (v1_a < 0)
                {
                    v1_a = 0;
                }
                v1_a += counter1;
            }

            if (keyboard[Key.Number1] && (v1_a >= -0.02f && v1_a <= 1.01f))
            {
                if (Math.Round(v1_a * 255) > 255)
                {
                    v1_a = 1.00f;
                }

                if (v1_a < 0)
                {
                    v1_a = 0;
                }
                v1_a -= counter1;
            }

            ///Vertex 2
            ///Vertex 2 Canal R

            if (keyboard[Key.R] && (v2_r >= -0.02f && v2_r <= 1.01f))
            {
                if (Math.Round(v2_r * 255) > 255)
                {
                    v2_r = 1.00f;
                }

                if (v2_r < 0)
                {
                    v2_r = 0;
                }
                v2_r += counter1;
            }

            if (keyboard[Key.E] && (v2_r >= -0.02f && v2_r <= 1.01f))
            {
                if (Math.Round(v2_r * 255) > 255)
                {
                    v2_r = 1.00f;
                }

                if (v2_r < 0)
                {
                    v2_r = 0;
                }
                v2_r -= counter1;
            }

            ///Vertex 2 Canal G

            if (keyboard[Key.F] && (v2_g >= -0.02f && v2_g <= 1.01f))
            {
                if (Math.Round(v2_g * 255) > 255)
                {
                    v2_g = 1.00f;
                }

                if (v2_g < 0)
                {
                    v2_g = 0;
                }
                v2_g += counter1;
            }

            if (keyboard[Key.D] && (v2_g >= -0.02f && v2_g <= 1.01f))
            {
                if (Math.Round(v2_g * 255) > 255)
                {
                    v2_g = 1.00f;
                }

                if (v2_g < 0)
                {
                    v2_g = 0;
                }
                v2_g -= counter1;
            }

            ///Vertex 2 Canal B

            if (keyboard[Key.V] && (v2_b >= -0.02f && v2_b <= 1.01f))
            {
                if (Math.Round(v2_b * 255) > 255)
                {
                    v2_b = 1.00f;
                }

                if (v2_b < 0)
                {
                    v2_b = 0;
                }
                v2_b += counter1;
            }

            if (keyboard[Key.C] && (v2_b >= -0.02f && v2_b <= 1.01f))
            {
                if (Math.Round(v2_b * 255) > 255)
                {
                    v2_b = 1.00f;
                }

                if (v2_b < 0)
                {
                    v2_b = 0;
                }
                v2_b -= counter1;
            }

            ///Vertex 2 Canal A

            if (keyboard[Key.Number4] && (v2_a >= -0.02f && v2_a <= 1.01f))
            {
                if (Math.Round(v2_a * 255) > 255)
                {
                    v2_a = 1.00f;
                }

                if (v2_a < 0)
                {
                    v2_a = 0;
                }
                v2_a += counter1;
            }

            if (keyboard[Key.Number3] && (v2_a >= -0.02f && v2_a <= 1.01f))
            {
                if (Math.Round(v2_a * 255) > 255)
                {
                    v2_a = 1.00f;
                }

                if (v2_a < 0)
                {
                    v2_a = 0;
                }
                v2_a -= counter1;
            }

            ///Vertex 3
            ///Vertex 3 Canal R

            if (keyboard[Key.Y] && (v3_r >= -0.02f && v3_r <= 1.01f))
            {
                if (Math.Round(v3_r * 255) > 255)
                {
                    v3_r = 1.00f;
                }

                if (v3_r < 0)
                {
                    v3_r = 0;
                }
                v3_r += counter1;
            }

            if (keyboard[Key.T] && (v3_r >= -0.02f && v3_r <= 1.01f))
            {
                if (Math.Round(v3_r * 255) > 255)
                {
                    v3_r = 1.00f;
                }

                if (v3_r < 0)
                {
                    v3_r = 0;
                }
                v3_r -= counter1;
            }

            ///Vertex 3 Canal G

            if (keyboard[Key.H] && (v3_g >= -0.02f && v3_g <= 1.01f))
            {
                if (Math.Round(v3_g * 255) > 255)
                {
                    v3_g = 1.00f;
                }

                if (v3_g < 0)
                {
                    v3_g = 0;
                }
                v3_g += counter1;
            }

            if (keyboard[Key.G] && (v3_g >= -0.02f && v3_g <= 1.01f))
            {
                if (Math.Round(v3_g * 255) > 255)
                {
                    v3_g = 1.00f;
                }

                if (v3_g < 0)
                {
                    v3_g = 0;
                }
                v3_g -= counter1;
            }

            ///Vertex 3 Canal B

            if (keyboard[Key.N] && (v3_b >= -0.02f && v3_b <= 1.01f))
            {
                if (Math.Round(v3_b * 255) > 255)
                {
                    v3_b = 1.00f;
                }

                if (v3_b < 0)
                {
                    v3_b = 0;
                }
                v3_b += counter1;
            }

            if (keyboard[Key.B] && (v3_b >= -0.02f && v3_b <= 1.01f))
            {
                if (Math.Round(v3_b * 255) > 255)
                {
                    v3_b = 1.00f;
                }

                if (v3_b < 0)
                {
                    v3_b = 0;
                }
                v3_b -= counter1;
            }

            ///Vertex 3 Canal A

            if (keyboard[Key.Number6] && (v3_a >= -0.02f && v3_a <= 1.01f))
            {
                if (Math.Round(v3_a * 255) > 255)
                {
                    v3_a = 1.00f;
                }

                if (v3_a < 0)
                {
                    v3_a = 0;
                }
                v3_a += counter1;
            }

            if (keyboard[Key.Number5] && (v3_a >= -0.02f && v3_a <= 1.01f))
            {
                if (Math.Round(v3_a * 255) > 255)
                {
                    v3_a = 1.00f;
                }

                if (v3_a < 0)
                {
                    v3_a = 0;
                }
                v3_a -= counter1;
            }

            x = mouse.X;
            y = mouse.Y;


        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
           
            GL.Viewport(0, 0, Width, Height);

            double aspect_ratio = Width / (double)Height;

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);

            float eyeX = 30f;
            float eyeY = 30f;
            float eyeZ = 30f;
            float targetX = 0.1f;
            float targetY = 0.0f;
            float targetZ = 0.1f;
            float upX = 0.0f;
            float upY = 1.0f;
            float upZ = 1.0f;


            Matrix4 lookat = Matrix4.LookAt(eyeX, eyeY, eyeZ, targetX, targetY, targetZ, upX, upY, upZ);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);


        }


        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            //GL.PushMatrix();
            //GL.Translate(x, y, z);

            GL.Viewport(x, -y, Width, Height);

            GL.Begin(PrimitiveType.Triangles);

            
            

            /*using (StreamReader file = new StreamReader("D:\\01_Facultate An III\\Semestrul I\\EGC\\Laboratoare\\Proiecte\\Lab 3\\Dinco\\Dinco\\Dinco\\coordonate.txt"))
            {

                string ln;
                string[] coordonate1;


                while ((ln = file.ReadLine()) != null)
                {
                    ln = File.ReadAllText("D:\\01_Facultate An III\\Semestrul I\\EGC\\Laboratoare\\Proiecte\\Lab 3\\Dinco\\Dinco\\Dinco\\coordonate.txt");
                    coordonate1 = ln.Split(", ");


                    for (int i = 0; i < coordonate1.Length; i++)
                    {
                        Console.WriteLine(coordonate1[i]);
                    }


                    float v1_x, v1_y;
                    float v2_x, v2_y;
                    float v3_x, v3_y;

                    v1_x = float.Parse(coordonate1[0]);
                    v1_y = float.Parse(coordonate1[1]);

                    v2_x = float.Parse(coordonate1[2]);
                    v2_y = float.Parse(coordonate1[3]);

                    v3_x = float.Parse(coordonate1[4]);
                    v3_y = float.Parse(coordonate1[5]);

                    GL.Color4(v1_r, v1_g, v1_b, v1_a);
                    GL.Vertex2(v1_x, v1_y);
                    GL.Color4(v2_r, v2_g, v2_b, v2_a);
                    GL.Vertex2(v2_x, v2_y);
                    GL.Color4(v3_r, v3_g, v3_b, v3_a);
                    GL.Vertex2(v3_x, v3_y);
                    
                }


                file.Close();

            }*/

            ///Lab 3 - Problema 8

            StreamReader f1 = new StreamReader("D:\\01_Facultate An III\\Semestrul I\\EGC\\Laboratoare\\Proiecte\\Lab 3\\Dinco\\Dinco\\Dinco\\coordonate.txt");
            int nrLinii = Int32.Parse(f1.ReadLine());
            for (int i = 0; i < nrLinii; i++) {

                string aux = f1.ReadLine();
                float[] coord = new float[aux.Length];
                coord[0] = float.Parse(aux.Split(',')[0]);
                coord[1] = float.Parse(aux.Split(',')[1]);
                if(i == 0)
                {
                    GL.Color4(v1_r, v1_g, v1_b, v1_a);
                }
                if (i == 1)
                {
                    GL.Color4(v2_r, v2_g, v2_b, v2_a);
                }
                if( i == 2)
                {
                    GL.Color4(v3_r, v3_g, v3_b, v3_a);
                }    
                GL.Vertex2(coord[0], coord[1]);
                


            }

            f1.Close();


            //GL.Color4(v1_r, v1_g, v1_b, v1_a);
            //GL.Vertex2(v1_x, v1_y);
            //GL.Color4(v2_r, v2_g, v2_b, v2_a);
            //GL.Vertex2(v2_x, v2_y);
            //GL.Color4(v3_r, v3_g, v3_b, v3_a);
            //GL.Vertex2(v3_x, v3_y);

            /*GL.Color4(v1_r, v1_g, v1_b, v1_a);
            GL.Vertex2(-10f, 10f);
            GL.Color4(v2_r, v2_g, v2_b, v2_a);
            GL.Vertex2(10f, 10f);
            GL.Color4(v3_r, v3_g, v3_b, v3_a);
            GL.Vertex2(10f, 0f);*/


            GL.End();

            //GL.PopMatrix();
            this.SwapBuffers();

        }

        static void Main(string[] args)
        {
            using (ImmediateMode example = new ImmediateMode())
            {
                example.Run(30.0, 0.0);
            }
        }
    }
}
