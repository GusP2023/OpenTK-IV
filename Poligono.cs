using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
//using System.Drawing;
//using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace Game2
{
    [Serializable]
    
    public class Poligono
    {
        //[JsonProperty("Vertices")]
        public Dictionary<String, Punto> vertices { get; set; }
        //[JsonProperty("Color")]
        public Punto color { get; set; }
        //[JsonProperty("TIPO DE DIBUJO")]
        public PrimitiveType Tipo { get; set; }
        public Punto Translation { get; set; }

        Matrix3 Rotation { get; set; } = Matrix3.Identity;

        Matrix3 Scaling { get; set; } = Matrix3.Identity;
        public Punto Center { get; set; }

        public Poligono() { }
        public Poligono(Punto color, PrimitiveType tipo, Punto origen)
        {
            vertices = new Dictionary<String, Punto>();
            this.color = color;
            this.Tipo = tipo;
            Center = origen;
            Translation = new Punto(0, 0, 0);
            //this.Rotation = Matrix3.Identity;
            //this.Scaling = Matrix3.Identity;
        }

        public void AddVertice(String descripcion, Punto vertex)
        {
            
            this.vertices.Add(descripcion, vertex);
            
        }

        public void CambiarColor(Punto color)
        {
            this.color = color;
        }
        public void Draw(Punto centro)
        {

            GL.Begin(Tipo);
            GL.Color3(color);
            
            foreach (var vertex in this.vertices)
            {
                Punto vertexToRender = vertex.Value * Rotation * Scaling;
                vertexToRender += Center + Translation + centro;
                GL.Vertex3(vertexToRender);
            } 
                        
            GL.End();
            GL.Flush();
        }
        public void Rotate(float angleX, float angleY, float angleZ)
        {
            angleX = MathHelper.DegreesToRadians(angleX);
            angleY = MathHelper.DegreesToRadians(angleY);
            angleZ = MathHelper.DegreesToRadians(angleZ);

            Rotation *= Matrix3.CreateRotationX(angleX) * Matrix3.CreateRotationY(angleY) *
                        Matrix3.CreateRotationZ(angleZ);
        }
        public void SetRotation(float angleX, float angleY, float angleZ)
        {
            angleX = MathHelper.DegreesToRadians(angleX);
            angleY = MathHelper.DegreesToRadians(angleY);
            angleZ = MathHelper.DegreesToRadians(angleZ);
            Rotation = Matrix3.CreateRotationX(angleX) * Matrix3.CreateRotationY(angleY) *
                       Matrix3.CreateRotationZ(angleZ);
        }
        public void Traslate(float x, float y, float z)
        {
            Translation = Translation + new Punto(x, y, z);
        }
        public void Traslate(Punto position)
        {
            Translation = Translation + position;
        }
        public void SetTraslation(Punto position)
        {
            Translation = position;
        }
        public void Scale(float x, float y, float z)
        {
            Scaling *= Matrix3.CreateScale(x, y, z);
        }
        public void Scale(Punto scale)
        {
            Scaling *= Matrix3.CreateScale(scale);
        }
        public void SetScale(float x, float y, float z)
        {
            Scaling = Matrix3.CreateScale(x, y, z);
        }

        public void SetScale(Punto scale)
        {
            Scaling = Matrix3.CreateScale(scale);
        }

    }
}
