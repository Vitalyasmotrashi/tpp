using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

//Егоров Николай Иванович
//12 л.р. по 4 б. каждая
//1,2 занятие баллы не снижаются
//После 2 занятия - -1 б.
//Минимум 1 б.
//1. Работоспособность кода.
//2. Читабельность (наличие комментариев).
namespace Chat
{
    class ChatC
    {
        byte[] bSem = new byte[1];
        
        public void Load(RichTextBox _rtbChat, Timer _tmrSem)
        {
            FileStream fSemR = File.OpenRead("Semaphore.txt");
            fSemR.Read(bSem, 0, 1);
            if (bSem[0] == Convert.ToByte('0'))
            {
                _tmrSem.Enabled = true;
                fSemR.Close();
            }
            else
            {
                fSemR.Close();
                bSem[0] = Convert.ToByte('0');
                FileStream fSemW = File.OpenWrite("Semaphore.txt");
                fSemW.Write(bSem, 0, 1);
                fSemW.Close();
                _rtbChat.LoadFile("Grasshopper.rtf");
                _tmrSem.Enabled = false;
            }           
        }
        public void Save(RichTextBox _rtbChat)
        {
            _rtbChat.SaveFile("Grasshopper.rtf");
            bSem[0] = Convert.ToByte('1');
            FileStream fSemW = File.OpenWrite("Semaphore.txt");
            fSemW.Write(bSem, 0, 1);
            fSemW.Close();
        }
        //Создать новый метод для имитации работы семафора.
        //При нажатии кнопки "Semaphore" должно выводиться состояние семафора: 0 или 1.
        //Метод Load уменьшает значение счетчика с 1 на 0 (блокировать семафор),
        //метод Save увеличивает значение счетчика с 0 на 1 (разблокировать семафор).
        //Необходимо предусмотреть обработку исключений при возникновении проблем при работе с файлом,
        //а также при значениях счетчика > 1 или < 0.
        //Для имитации работы семафора использовать конструкцию try catch.
        //Проверка работы осуществляется с помощью открытия двух окон файла Chat.exe.
        //Код методов Load и Save - не изменять.
        // Не удалять текстовые файлы, находящиеся по пути \Chat\bin\Debug.
        /*
         * try
         * {
         *  действие
         * }
         * catch
         * {
         *  обработка исключения
         * }
         * finally
         * {
         *  действия при отсутствии исключений или после
         *  обработки исключения
         * }
         * Пример
         * try
         * {
         *  int x = 5;
         *  int y = x/0;
         *  Console.WriteLine($"Результат: {y}"); 
         * }
         * catch
         * {
         *  Console.WriteLine("На 0 делить нельзя!");
         * }
         * finally
         * {
         *  Console.WriteLine("Конец программы.");
         * }
         */
        public void ShowSemaphore(RichTextBox _rtbChat)
        {
            try
            {
                using (FileStream fSemR = File.OpenRead("Semaphore.txt"))
                {
                    fSemR.Read(bSem, 0, 1);
                }

                int semValue = bSem[0] - '0';

                if (semValue < 0 || semValue > 1)
                    throw new Exception("Некорректное значение семафора!");

                _rtbChat.AppendText($"Состояние семафора: {semValue}\n");
            }
            catch (FileNotFoundException)
            {
                _rtbChat.AppendText("Файл Semaphore.txt не найден!\n");
            }
            catch (Exception ex)
            {
                _rtbChat.AppendText($"Ошибка: {ex.Message}\n");
            }
            finally
            {
                _rtbChat.AppendText("Проверка завершена.\n");
            }
        }
    }
}
