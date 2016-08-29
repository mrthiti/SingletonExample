using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample {
    class Program {
        static void Main(string[] args) {
            singletonClass obj = singletonClass.getInstance();
            Console.WriteLine(obj != null);
            Console.ReadKey();
        }
    }

    public class singletonClass{

        //สร้างตัวแปรสําหรับเก็บ Object ของ class
        private static singletonClass _instance = null;

        //ให้ constructor เป็น private เพื่อทําให้ไม่สามารถสร้าง Object ได้
        private singletonClass() { }

        //Function สําหรับสร้าง Object และ return ออกไป
        //ในกรณีที่มีแล้วให้ return ออกไปเลย
        public static singletonClass getInstance() {

            if (_instance == null) {
                _instance = new singletonClass();
            }

            return _instance;
        }

    }

}
