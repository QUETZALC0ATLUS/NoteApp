using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    /// <summary>
    /// Класс «Менеджер проекта». Реализует метод для сохранения объекта «Проект» в 
    /// файл и метод загрузки проекта из файла.
    /// </summary>
    public class ProjectManager
    {
        Note note = new Note();

        /// <summary>
        /// Имя файла, заданное закрытой константой.
        /// </summary>
        private const string file = "NoteApp.notes";

        /// <summary>
        /// Метод для сохранения объекта «Проект» в файл.
        /// </summary>
        public void SaveObject()
        {   
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();

            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(file))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, note);
            }
        }

        /// <summary>
        /// Метод для загрузки объекта «Проект» из файла.
        /// </summary>
        public void DownloadObject()
        {
            //Создаём переменную, в которую поместим результат десериализации
            Note note = null;

            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();

            //Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(file))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                note = (Note)serializer.Deserialize<Note>(reader);
            }
        }
    }
}
