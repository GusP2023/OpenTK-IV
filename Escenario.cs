using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using Game2;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.IO.Ports;

namespace Game2
{
    [Serializable]
    public class Escenario
    {
        //[JsonProperty("OBJETOS")]
        public Dictionary<string, Objeto> Objeto { get; set; }
        //[JsonProperty("CenTRO")]
        public Punto Center { get; set; }
        //public Matrix3 Rotation { get; set; }
        //public Matrix3 Scaling { get; set; }
        public Escenario() { }
        public Escenario(Dictionary<String, Objeto> ListObjeto, Punto centro)
        {
            this.Objeto = ListObjeto;
            this.Center = centro;
            SetCenter(this.Center);

        }
        public Escenario(float x,float y,float z)
        {
            this.Objeto = new Dictionary<string, Objeto>();
            this.Center = new Punto(x,y,z);
            SetCenter(this.Center);

        }
        public Escenario(Punto centro)
        {
            this.Objeto = new Dictionary<string, Objeto>();
            this.Center = centro;
            SetCenter(this.Center);

        }        
        public void SaveFile(string path)
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true                
            };

            string jsonOutput = JsonSerializer.Serialize(this, options);

            File.WriteAllText(path, jsonOutput);
        }
        public void addObjeto(String descripcion, Objeto objeto)
        {
            objeto.SetCenter(objeto.GetCenter() + Center);
            this.Objeto.Add(descripcion, objeto);
        }
        public Objeto GetObject3D(string key)
        {
            return Objeto[key];
        }
        public void draw()
        {
            if (this.Objeto.Count != 0)
            {
                foreach (var parte in this.Objeto)
                {
                    parte.Value.draw();
                }
            }
        }
        public void rotate(float rotarx, float rotary)
        {
            GL.Rotate(rotarx, 1, 0, 0);
            GL.Rotate(rotary, 0, 1, 0);
        }
        public void Rotate(float angleX, float angleY, float angleZ)
        {
            foreach (var object3D in Objeto)
            {
                object3D.Value.Rotate(angleX, angleY, angleZ);
            }
        }
        public void SetRotation(float angleX, float angleY, float angleZ)
        {
            foreach (var object3D in Objeto)
                object3D.Value.SetRotation(angleX, angleY, angleZ);
        }
        public void translate(Punto position)
        {
            foreach (var object3D in Objeto)
                object3D.Value.Traslate(position);
        }
        public void SetTraslation(Punto position)
        {
            foreach (var object3D in Objeto)
                object3D.Value.SetTraslation(position);
        }
        public Punto GetCenter()
        {
            return Center;
        }
        public void SetCenter(Punto center)
        {
            Center = center;
            foreach (var object3D in Objeto)
            {
                Punto formerCenter = object3D.Value.GetCenter();
                object3D.Value.SetCenter(Center + formerCenter);
            }
        }
        public void Scale(float x, float y, float z)
        {
            foreach (var object3D in Objeto)
                object3D.Value.Scale(x, y, z);
        }

        public void Scale(Punto position)
        {
            foreach (var object3D in Objeto)
                object3D.Value.Scale(position);
        }

        public void SetScale(float x, float y, float z)
        {
            foreach (var object3D in Objeto)
                object3D.Value.SetScale(x, y, z);
        }

        public void SetScale(Punto position)
        {
            foreach (var object3D in Objeto)
                object3D.Value.SetScale(position);
        }
    }
}
