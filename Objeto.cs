//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Game2
{
    [Serializable]
    public class Objeto
    {
        //[JsonProperty("PartesO")]
        public Dictionary<string, Partes> parte { get; set; }
        //[JsonProperty("CENTRO")]
        public Punto Center { get; set; }

        public Objeto() { }
        public Objeto(Dictionary<string, Partes> parte, Punto centro)
        {
            this.parte = parte;
            this.Center = centro;
            SetCenter(this.Center);
        }
        public Objeto(float x, float y, float z)
        {
            this.parte = new Dictionary<string, Partes>();
            this.Center = new Punto(x, y, z);
            SetCenter(this.Center);
        }
        public void addParte(String descripcion, Partes parte)
        {
            this.parte.Add(descripcion, parte);
        }
        public void draw()
        {
            if (this.parte.Count != 0)
            {
                foreach (var parte in this.parte)
                {
                    parte.Value.draw(Center);
                }
            }

        }
        public void SetCenter(Punto newCenter)
        {
            Center = newCenter;
            foreach (var face in parte)
                face.Value.Center = Center;
        }
        //public static Objeto LoadFromJson(string path)
        //{
        //    string outputString = File.ReadAllText(path);
        //    return dt = (Objeto)JsonConvert.DeserializeObject<Objeto>(outputString);
        //}

        //public void LoadFromJson(string path)
        //{
        //    string outputString = File.ReadAllText(@path);
        //    Objeto dt = (Objeto)JsonConvert.DeserializeObject(outputString, typeof(Objeto));
        //    parte = dt.parte;
        //    center = dt.center;
        //    SetCenter(center);
        //}
        public static Objeto LoadFromJson(string path)
        {
            string outputString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Objeto>(outputString);
        }

        public void SaveFile(string path)
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true
            };

                string jsonOutput = JsonSerializer.Serialize(this, options);

            File.WriteAllText(path, jsonOutput);
        }
        public Punto GetCenter()
        {
            return Center;
        }
        public void Rotate(float angleX, float angleY, float angleZ)
        {
            foreach (var face in parte)
                face.Value.Rotate(angleX, angleY, angleZ);
        }
        public void SetRotation(float angleX, float angleY, float angleZ)
        {
            foreach (var face in parte)
                face.Value.SetRotation(angleX, angleY, angleZ);
        }
        public void Traslate(Punto position)
        {
            foreach (var partes in parte)
                partes.Value.Traslate(position);
        }
        public void SetTraslation(Punto position)
        {
            foreach (var face in parte)
                face.Value.SetTraslation(position);
        }
        public void Scale(float x, float y, float z)
        {
            foreach (var face in parte)
                face.Value.Scale(x, y, z);
        }

        public void Scale(Punto position)
        {
            foreach (var face in parte)
                face.Value.Scale(position);
        }

        public void SetScale(float x, float y, float z)
        {
            foreach (var face in parte)
                face.Value.SetScale(x, y, z);
        }

        public void SetScale(Punto position)
        {
            foreach (var face in parte)
                face.Value.SetScale(position);
        }

    }
}
