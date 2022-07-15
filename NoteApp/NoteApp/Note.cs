using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteApp
{
    
    /// <summary>
    /// Класс «Заметка».
    /// </summary>
    public class Note: ICloneable
    {        
        public object Clone()
        {
            return this;
        }

        /// <summary>
        /// Задаёт и возвращает название заметки. 
        /// </summary>
        private string _name;
        
        public string Name
        {
            get => _name;

            set
            {
                if (value.Length > 50 )
                    throw new ArgumentException("Название не может содержать более 50 символов");

                else
                    _name = value;

                if (value.Length == 0)
                    _name = "Без названия";
            }                
        }
       
        /// <summary>
        /// Возвращает и задаёт категорию заметки.
        /// </summary>
        public string NoteCategory { get; set; }

        /// <summary>
        /// Возвращает и задаёт текст заметки.
        /// </summary>
        public string NoteText { get; set; }

        /// <summary>
        /// Возвращает время создания заметки.
        /// </summary>
        private readonly DateTime _timeOfCreation;
       
        /// <summary>
        /// Время последнего изменения. Меняется автоматически при изменении названия, категории или текста заметки.
        /// </summary>
        private DateTime _lastModifiedTime;        

        public DateTime LastModifiedTime
        {
            get
            {
                return _lastModifiedTime;
            }

            set
            {
                if (Name != null || NoteCategory != null || NoteText != null)
                    _lastModifiedTime = value;
            }

        }        
        /// <summary>
        /// Инициализирует время создания один раз при создании объекта.
        /// </summary>
        /// <param name="timeOfCreation">Значение времени создания заметки</param>
        public Note()
        {            
            _timeOfCreation = DateTime.Now;
            _name = "Без названия"; // Задаёт название заметки по умолчанию
        }
                
    }
}
