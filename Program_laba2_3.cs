using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{

    class DocumentWorker
    {
        public DocumentWorker(string u_key)
        {
            Console.WriteLine("Вы работаете в Based версии программы Scamsoft Word 2022");
        }
        public virtual void OpenDocument() { Console.WriteLine("Документ открыт"); }
        public virtual void EditDocument() { Console.WriteLine("Редактирование документа доступно в версии Pro"); }
        public virtual void SaveDocument() { Console.WriteLine("Сохранение документа доступно в версии Pro"); }
    }
    class ProDocumentWorker : DocumentWorker
    {

        private string pro_key = "123ABC";
        public ProDocumentWorker(string u_key) : base(u_key)
        {
            if (u_key == pro_key)
                Console.WriteLine("Активирована Pro версия");
        }
        public virtual new void EditDocument() { Console.WriteLine("Документ отредактирован"); }
        public virtual new void SaveDocument() { Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert"); }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        private string expert_key = "123ABC+";
        public ExpertDocumentWorker(string u_key) : base(u_key)
        {
            if (u_key == expert_key)
                Console.WriteLine("Активирована Expert версия");
        }
        public new void SaveDocument() { Console.WriteLine("Документ сохранен в новом формате"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введите ключ продукта: ");
            string user_key = Console.ReadLine();

            ExpertDocumentWorker USER = new ExpertDocumentWorker(user_key);
            
            Console.Read();
        }
    }
}