using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;

namespace Game2
{
    public class Game : GameWindow
    {
        private float rotationX = 10;
        private float rotationY = 10;
        private float lastX;
        private float lastY;
        private bool mouseDown;
        private float ancho=10;
        private float alto=10;
        private float profundidad = 10;
        public Vector3 origen= new Vector3(0,0,0);
        public Escenario escenario,escenario2;
        public Objeto TV,TV2;


        //-----------------------------------------------------------------------------------------------------------------
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnLoad(EventArgs e)
        {
            
            //-------------------------------------------------------------------------------------------------------------------------
            //Poligono pantalla = new Poligono(new Punto(0, 0, 0), PrimitiveType.Polygon, new Punto(0, 0, 0));
            ////c = Color4.Black;//black DERECHA
            //pantalla.AddVertice("pantallav1", new Punto(origen.X + ancho, origen.Y + alto, origen.Z - profundidad * 0.2f));
            //pantalla.AddVertice("pantallav2", new Punto(origen.X + ancho, origen.Y + alto, origen.Z + profundidad * 0.2f));
            //pantalla.AddVertice("pantallav3", new Punto(origen.X + ancho, origen.Y - alto, origen.Z + profundidad * 0.2f));
            //pantalla.AddVertice("pantallav4", new Punto(origen.X + ancho, origen.Y - alto, origen.Z - profundidad * 0.2f));
            ////c = Color4.Blue;//blue frente
            //pantalla.AddVertice("pantallav5", new Punto(origen.X + ancho, origen.Y + alto, origen.Z + profundidad * 0.2f));
            //pantalla.AddVertice("pantallav6", new Punto(origen.X - ancho, origen.Y + alto, origen.Z + profundidad * 0.2f));
            //pantalla.AddVertice("pantallav7", new Punto(origen.X - ancho, origen.Y - alto, origen.Z + profundidad * 0.2f));
            ////c = Color4.Black;
            //pantalla.AddVertice("pantallav8", new Punto(origen.X + ancho, origen.Y - alto, origen.Z + profundidad * 0.2f));
            ////c = Color4.Black;//black IZQUIERDA
            //pantalla.AddVertice("pantallav9", new Punto(origen.X - ancho, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //pantalla.AddVertice("pantallav10", new Punto(origen.X - ancho, origen.Y + alto, origen.Z - profundidad * 0.2f));
            //pantalla.AddVertice("pantallav11", new Punto(origen.X - ancho, origen.Y + alto, origen.Z + profundidad * 0.2f));
            //pantalla.AddVertice("pantallav12", new Punto(origen.X - ancho, origen.Y - alto, origen.Z + profundidad * 0.2f));
            ////c = Color4.Yellow;//amarillo ABAJO
            //pantalla.AddVertice("pantallav13", new Punto(origen.X + ancho, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //pantalla.AddVertice("pantallav14", new Punto(origen.X - ancho, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //pantalla.AddVertice("pantallav15", new Punto(origen.X - ancho, origen.Y - alto, origen.Z + profundidad * 0.2f));
            //pantalla.AddVertice("pantallav16", new Punto(origen.X + ancho, origen.Y - alto, origen.Z + profundidad * 0.2f));
            ////c = Color4.Blue;//blue atras
            //pantalla.AddVertice("pantallav17", new Punto(origen.X + ancho, origen.Y + alto, origen.Z - profundidad * 0.2f));
            //pantalla.AddVertice("pantallav18", new Punto(origen.X - ancho, origen.Y + alto, origen.Z - profundidad * 0.2f));
            //pantalla.AddVertice("pantallav19", new Punto(origen.X - ancho, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //pantalla.AddVertice("pantallav20", new Punto(origen.X + ancho, origen.Y - alto, origen.Z - profundidad * 0.2f));
            ////c=Color4.Yellow;//amarillo ARRIBA
            //pantalla.AddVertice("pantallav21", new Punto(origen.X + ancho, origen.Y + alto, origen.Z - profundidad * 0.2f));
            //pantalla.AddVertice("pantallav22", new Punto(origen.X - ancho, origen.Y + alto, origen.Z - profundidad * 0.2f));
            //pantalla.AddVertice("pantallav23", new Punto(origen.X - ancho, origen.Y + alto, origen.Z + profundidad * 0.2f));
            //pantalla.AddVertice("pantallav24", new Punto(origen.X + ancho, origen.Y + alto, origen.Z + profundidad * 0.2f));
            //Partes pantallaP = new Partes(0, 0, 0);
            //pantallaP.addPoligono("pantalla", pantalla);
            //Poligono parlanteizq = new Poligono(new Punto(0, 1, 0), PrimitiveType.Polygon, new Punto(0, 0, 0));
            ////GL.Color3(0, 1.0, 0.0);//verde PARLANTE IZQUIERDO FRENTE
            //parlanteizq.AddVertice("parlantev1", new Punto(origen.X - ancho / 10, origen.Y - alto, origen.Z + profundidad * 0.2f));
            //parlanteizq.AddVertice("parlantev2", new Punto(origen.X - ancho / 10, origen.Y - alto - (alto * 0.2f), origen.Z + profundidad * 0.2f));
            //parlanteizq.AddVertice("parlantev3", new Punto(origen.X - ancho, origen.Y - alto - (alto * 0.2f), origen.Z + profundidad * 0.2f));
            //parlanteizq.AddVertice("parlantev4", new Punto(origen.X - ancho, origen.Y - alto, origen.Z + profundidad * 0.2f));
            ////GL.Color3(0, 1.0, 0.0);//verde PARLANTE IZQUIERDO IZQUIERDA
            //parlanteizq.AddVertice("parlantev5", new Punto(origen.X - ancho, origen.Y - alto, origen.Z + profundidad * 0.2f));
            //parlanteizq.AddVertice("parlantev6", new Punto(origen.X - ancho, origen.Y - alto - (alto * 0.2f), origen.Z + profundidad * 0.2f));
            //parlanteizq.AddVertice("parlantev7", new Punto(origen.X - ancho, origen.Y - alto - (alto * 0.2f), origen.Z - profundidad * 0.2f));
            //parlanteizq.AddVertice("parlantev8", new Punto(origen.X - ancho, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //parlanteizq.AddVertice("parlantev4.1", new Punto(origen.X - ancho, origen.Y - alto, origen.Z + profundidad * 0.2f));
            ////GL.Color3(0, 1.0, 0.0);//verde PARLANTE IZQUIERDO ATRAS
            //parlanteizq.AddVertice("parlantev9", new Punto(origen.X - ancho, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //parlanteizq.AddVertice("parlantev10", new Punto(origen.X - ancho, origen.Y - alto - (alto * 0.2f), origen.Z - profundidad * 0.2f));
            //parlanteizq.AddVertice("parlantev11", new Punto(origen.X - ancho / 10, origen.Y - alto - (alto * 0.2f), origen.Z - profundidad * 0.2f));
            //parlanteizq.AddVertice("parlantev12", new Punto(origen.X - ancho / 10, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //parlanteizq.AddVertice("parlantev9.1", new Punto(origen.X - ancho, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //Partes parlanteI = new Partes(0, 0, 0);
            //parlanteI.addPoligono("parlanteizq", parlanteizq);
            //Poligono parlanteder = new Poligono(new Punto(0, 1, 0), PrimitiveType.Polygon, new Punto(0, 0, 0));
            //GL.Color3(0, 1.0, 0.0);//verde PARLANTE DERECHA FRENTE
            //parlanteder.AddVertice("parlantev1", new Punto(origen.X + ancho / 10, origen.Y - alto, origen.Z + profundidad * 0.2f));
            //parlanteder.AddVertice("parlantev2", new Punto(origen.X + ancho / 10, origen.Y - alto - (alto * 0.2f), origen.Z + profundidad * 0.2f));
            //parlanteder.AddVertice("parlantev3", new Punto(origen.X + ancho, origen.Y - alto - (alto * 0.2f), origen.Z + profundidad * 0.2f));
            //parlanteder.AddVertice("parlantev4", new Punto(origen.X + ancho, origen.Y - alto, origen.Z + profundidad * 0.2f));
            ////GL.Color3(0, 1.0, 0.0);//verde PARLANTE DERECHA DERECHA
            //parlanteder.AddVertice("parlantev5", new Punto(origen.X + ancho, origen.Y - alto, origen.Z + profundidad * 0.2f));
            //parlanteder.AddVertice("parlantev6", new Punto(origen.X + ancho, origen.Y - alto - (alto * 0.2f), origen.Z + profundidad * 0.2f));
            //parlanteder.AddVertice("parlantev7", new Punto(origen.X + ancho, origen.Y - alto - (alto * 0.2f), origen.Z - profundidad * 0.2f));
            //parlanteder.AddVertice("parlantev8", new Punto(origen.X + ancho, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //parlanteder.AddVertice("parlantev5.1", new Punto(origen.X + ancho, origen.Y - alto, origen.Z + profundidad * 0.2f));
            ////GL.Color3(0, 1.0, 0.0);//verde PARLANTE DERECHA ATRAS
            //parlanteder.AddVertice("parlantev9", new Punto(origen.X + ancho, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //parlanteder.AddVertice("parlantev10", new Punto(origen.X + ancho, origen.Y - alto - (alto * 0.2f), origen.Z - profundidad * 0.2f));
            //parlanteder.AddVertice("parlantev11", new Punto(origen.X + ancho / 10, origen.Y - alto - (alto * 0.2f), origen.Z - profundidad * 0.2f));
            //parlanteder.AddVertice("parlantev12", new Punto(origen.X + ancho / 10, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //parlanteder.AddVertice("parlantev9.1", new Punto(origen.X + ancho, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //Partes parlanteD = new Partes(0, 0, 0);
            //parlanteD.addPoligono("parlanteder", parlanteder);
            //Poligono soporte = new Poligono(new Punto(0, 0, 1), PrimitiveType.Polygon, new Punto(0, 0, 0));
            //GL.Color3(0, 0.0, 0.0);//BLACK SOPORTE FRENTE
            //soporte.AddVertice("soportev1", new Punto(origen.X - ancho * 0.05f, origen.Y - alto, origen.Z + profundidad * 0.2f));
            //soporte.AddVertice("soportev2", new Punto(origen.X - ancho * 0.2f, origen.Y - alto * 2 + (alto * 0.2f), origen.Z + profundidad * 0.2f));
            //soporte.AddVertice("soportev3", new Punto(origen.X + ancho * 0.2f, origen.Y - alto * 2 + (alto * 0.2f), origen.Z + profundidad * 0.2f));
            //soporte.AddVertice("soportev4", new Punto(origen.X + ancho * 0.05f, origen.Y - alto, origen.Z + profundidad * 0.2f));
            ////GL.Color3(0, 0.0, 0.0);//BLACK SOPORTE DERECHA
            //soporte.AddVertice("soportev5", new Punto(origen.X - ancho * 0.05f, origen.Y - alto, origen.Z + profundidad * 0.2f));
            //soporte.AddVertice("soportev6", new Punto(origen.X - ancho * 0.2f, origen.Y - alto * 2 + (alto * 0.2f), origen.Z + profundidad * 0.2f));
            //soporte.AddVertice("soportev7", new Punto(origen.X - ancho * 0.2f, origen.Y - alto * 2 + (alto * 0.2f), origen.Z - profundidad * 0.2f));
            //soporte.AddVertice("soportev8", new Punto(origen.X - ancho * 0.05f, origen.Y - alto, origen.Z - profundidad * 0.2f));
            ////GL.Color3(0, 0.0, 0.0);//BLACK SOPORTE izquierda
            //soporte.AddVertice("soportev9", new Punto(origen.X + ancho * 0.05f, origen.Y - alto, origen.Z + profundidad * 0.2f));
            //soporte.AddVertice("soportev10", new Punto(origen.X + ancho * 0.2f, origen.Y - alto * 2 + (alto * 0.2f), origen.Z + profundidad * 0.2f));
            //soporte.AddVertice("soportev11", new Punto(origen.X + ancho * 0.2f, origen.Y - alto * 2 + (alto * 0.2f), origen.Z - profundidad * 0.2f));
            //soporte.AddVertice("soportev12", new Punto(origen.X + ancho * 0.05f, origen.Y - alto, origen.Z - profundidad * 0.2f));
            ////GL.Color3(0, 0.0, 0.0);//BLACK SOPORTE ATRAS
            //soporte.AddVertice("soportev13", new Punto(origen.X - ancho * 0.05f, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //soporte.AddVertice("soportev14", new Punto(origen.X - ancho * 0.2f, origen.Y - alto * 2 + (alto * 0.2f), origen.Z - profundidad * 0.2f));
            //soporte.AddVertice("soportev15", new Punto(origen.X + ancho * 0.2f, origen.Y - alto * 2 + (alto * 0.2f), origen.Z - profundidad * 0.2f));
            //soporte.AddVertice("soportev16", new Punto(origen.X + ancho * 0.05f, origen.Y - alto, origen.Z - profundidad * 0.2f));
            //Partes soporteO = new Partes(0, 0, 0);
            //soporteO.addPoligono("SoporteO", soporte);
            //Objeto TV = new Objeto(0, 0, 0);

            //TV.addParte("pantalla", pantallaP);
            //TV.addParte("ParlanteIzquierda", parlanteI);
            //TV.addParte("ParlanteDerecha", parlanteD);
            //TV.addParte("Soporte", soporteO);

            //-------------------------------------------------------------------------------------------------------------------------
            GL.ClearColor(0.5f, 0f, 0f, 0f);
            escenario = new Escenario(0, 0, 0);
            //escenario2 = new Escenario(-15, -15, 0);

            TV = Objeto.LoadFromJson("Pantalla.json");
            TV2 = Objeto.LoadFromJson("Pantalla.json");

            TV.SetCenter(new Punto(15,15,0));
            TV2.SetCenter(new Punto(-15,-15, 0));
            
            escenario.addObjeto("Televisor", TV);
            escenario.addObjeto("Televisor2", TV2);

            //escenario2.addObjeto("Televisor2", TV2);
            //TV.SaveFile("PantallaE.json");

            base.OnLoad(e); 
        }        
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //GL.DeleteBuffer(VertexBufferObject);
            base.OnUnload(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //GL.DepthMask(true);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();
            //--------------------------------------------------------------            

            escenario.rotate(rotationX, rotationY);
            //escenario.Rotate(1,0,0);
            //escenario.SetRotation(90,0,0);
            //escenario.SetScale(1.5f,1.5f,1.5f);
            escenario.draw();
            //escenario2.rotate(rotationX, rotationY);
            //escenario2.draw();
            
            //-------------------------------------------------------------

            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Key.Escape))
            {
                Exit();
                return;
            }

            //------------------------------------------------------------------------------------
            MouseMove += (sender, args) =>
            {
                if (mouseDown)
                {
                    float deltaX = args.X - lastX;
                    float deltaY = args.Y - lastY;

                    rotationX += deltaY * 0.2f;
                    rotationY += deltaX * 0.2f;
                }
                lastX = args.X;
                lastY = args.Y;
            };

            MouseDown += (sender, args) =>
            {
                if (args.Button == MouseButton.Left)
                {
                    mouseDown = true;
                }
            };

            MouseUp += (sender, args) =>
            {
                if (args.Button == MouseButton.Left)
                {
                    mouseDown = false;
                }
            };
            //----------------------------------------------------------------------------------
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnResize(EventArgs e)
        {
            float d = 30;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-d, d, -d, d, -d, d);
            //GL.Frustum(-d, d, -d, d,2, 100);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }



    }
}

