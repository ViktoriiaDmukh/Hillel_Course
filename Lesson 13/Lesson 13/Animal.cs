using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Створіть абстрактний клас Animal, який представляє тварину.

     У цьому класі повинні бути оголошені абстрактні методи MakeSound() та Move(), 

     які будуть визначати звук, який видає тварина, і спосіб її пересування відповідно. 

     Потім створіть конкретні класи Dog і Bird, які успадковують клас Animal і реалізують його абстрактні методи.

    Вимоги:

    1. Абстрактний клас Animal повинен містити абстрактні методи MakeSound() та Move().

    2. Клас Dog повинен реалізовувати методи MakeSound() та Move() таким чином, щоб MakeSound() виводив "Bark", а Move() виводив "Runs".

    3. Клас Bird повинен реалізовувати методи MakeSound() та Move() таким чином, щоб MakeSound() виводив "Chirp", а Move() виводив "Flies".

    4. Створіть екземпляри класів Dog і Bird і викличте їх методи MakeSound() та Move().

    */
namespace Lesson_13
{
    abstract class Animal
    {
        public abstract void MakeSound();

        public abstract void Move();
    }
}
