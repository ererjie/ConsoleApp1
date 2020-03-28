//using ConsoleApp2.MyNamespace;
//using ConsoleApp2.MyNamespace.Names1;
using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //}

    //#region 矩形计算

    ///// <summary>
    ///// 矩形
    ///// </summary>
    //public class Program1
    //{
    //    public static void Main(string[] args)
    //    {
    //        ProgramTest programTest = new ProgramTest();
    //        programTest.GetArea();
    //        programTest.Acceptdetails();
    //        programTest.Disolay();
    //        Console.ReadLine();
    //    }
    //}

    //public class ProgramTest
    //{
    //    private double length;
    //    private double width;

    //    public void Acceptdetails()
    //    {
    //        length = 4.5;
    //        width = 3.5;
    //    }

    //    public double GetArea()
    //    {
    //        return length * width;
    //    }

    //    public void Disolay()
    //    {
    //        Console.WriteLine("矩形长度:{0}", length);
    //        Console.WriteLine("矩形宽度:{0}", width);
    //        Console.WriteLine("矩形面积:{0}", GetArea());//{0}首个占位是0，{0}{1}{2}{3}
    //    }
    //}
    //#endregion


    //#region using语句

    ///// <summary>
    ///// using语句
    ///// </summary>
    //public class Program2
    //{
    //    public static void Main(string[] args)
    //    {
    //        UsingProgramTest2 usingTest = new UsingProgramTest2();
    //        using (usingTest)
    //        {
    //            usingTest.UseLimitedResource();
    //        }
    //        Console.WriteLine("Now outside using statements");
    //        Console.ReadKey();
    //    }
    //} 
    //#endregion

    //#region 引用
    ///// <summary>
    ///// 引用
    ///// </summary>
    /////
    //using names1 = ConsoleApp2.Names1;
    //using name2 = ConsoleApp2.Names2;
    //public class Program3
    //{
    //    //public static void Main(string[] args)
    //    //{
    //    //    NamesClass namesClass = new NamesClass();
    //    //    Console.WriteLine(namesClass.GetName());
    //    //    Console.ReadLine();
    //    //}

    //    /// <summary>
    //    /// ReadKey
    //    /// </summary>
    //    /// <param name="args"></param>
    //    /*public static void Main(string[] args)
    //    {
    //        Console.WriteLine("您的姓名是：");
    //        string name1 = Console.ReadLine();
    //        Console.WriteLine("您今年的年龄是：");
    //        int age1 = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("您父亲的名字：");
    //        string name2 = Console.ReadLine();
    //        Console.WriteLine("您父亲的年龄是：");
    //        int age2 = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine($"您父亲的名字是：{name2},今年{age2}");
    //        Console.WriteLine($"您的名字是：{name1},您的年龄：{age1}");
    //        //Console.ReadKey();
    //        Console.ReadLine();
    //    }*/



    //}
    //#endregion

    //#region 构造函数非静态
    ///// <summary>
    ///// 构造函数非静态
    ///// </summary>
    //public class Program4
    //{
    //    public decimal x, y;
    //    public Program4()
    //    {

    //    }
    //    public Program4(decimal x, decimal y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //    public override string ToString()
    //    {
    //        return (String.Format("({0},{1})", x, y));
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Program4 p1 = new Program4();
    //        Program4 p2 = new Program4(1.11111m, (decimal)2.2222);
    //        Console.WriteLine(p1);
    //        Console.WriteLine(p2);
    //        Console.ReadLine();
    //    }
    //} 
    //#endregion

    //    #region ref
    //    /// <summary>
    //    /// ref
    //    /// </summary>
    //    public class Program5
    //    {
    //        public static void Main(string[] args)
    //        {
    //            int c = 0;
    //            Add(1, 2, ref c);
    //            Console.WriteLine(c);
    //        }

    //        static void Add(int a, int b, ref int c)
    //        {
    //            c = a + b;
    //        }
    //    }

    //    #endregion


    #region delegate委托
    /// <summary>
    /// delegate委托
    /// </summary>
    //public class Program6
    //{
    //    public delegate int delegates(int x, int y);
    //    private static int Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //    static void Main(string[] args)
    //    {
    //        var dels = new delegates(Add);
    //        Console.WriteLine(dels(20, 22));
    //        Console.ReadLine();
    //    }
    //}

    //public class Program12
    //{
    //   public delegate string Delegates(string x);
    //   public static string Get(string x)
    //    {
    //       return x;
    //    }

    //    static void Main(string[] args)
    //    {
    //        /*Delegates del = Get;
    //        Console.WriteLine(del("123456"));*/

    //        //Delegates del = new Delegates(Get);
    //        //Console.WriteLine(del("{0}")); 

    //         //Delegates del = (str, nta) => Get(str);
    //         //Console.WriteLine(del("123465"));

    //        Delegates del = (str) => { return ($"{str}");  };
    //        Console.WriteLine(del("哈喽"));
    //        Console.WriteLine();
    //        Console.ReadLine();
    //    }
    //}

    #endregion

    //#region Action委托
    ///// <summary>+
    ///// Action委托
    ///// </summary>
    //public class Program7
    //{
    //    public static void Test<T>(Action<T> action, T t)
    //    public static void Test<T>(Action<T> action, T t)
    //    {
    //        action(t);
    //    }
    //    private static void Action(string s)
    //    {
    //        Console.WriteLine(s);
    //    }
    //    private static void Action(int s)
    //    {
    //        Console.WriteLine(s);
    //    }

    //    static void Main(string[] args)
    //    {
    //        Test<string>(Action, "asdfasdf");
    //        Test<int>(Action, 111);
    //        Test<string>(x => { Console.WriteLine("{0}", x); }, "asdfasdf");
    //        Console.ReadLine();
    //    }
    //}

    //public class Program11
    //{
    //    public static void Get(Action<string>action,string x)
    //    {
    //        action(x);
    //    }

    //    static void Main(string[] args)
    //    {

    //        Get(x=> Console.WriteLine(x),"中国");
    //        Console.ReadLine();
    //    }
    //}
    //#endregion


    #region Func委托
    /// <summary>
    /// Func委托
    /// </summary>
    //public class Program8
    //{
    //    public static int Test<T1, T2>(Func<T1, T2, int> func, T1 a, T2 b)
    //    {
    //        return func(a, b);
    //    }
    //    private static int Fun(int d, int g)
    //    {
    //        return d + g;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(Test<int, int>(Fun, 20, 33));
    //        Console.ReadLine();
    //    }
    //} 

    //public class Program9
    //{
    //    public static string Get(Func<string, string, string> func, string x, string y)
    //    {
    //        return func(x, y);
    //    }
    //    static void Main(string[] args)

    //    {
    //        var content = Get((a, b) => { return ($"{a}_{b}"); }, "你好", "世界");
    //        Console.WriteLine(content);
    //        Console.ReadLine();
    //    }
    //}

    //public class Program10
    //{
    //    public static decimal GetTotal(Func<decimal,int,decimal >func,decimal x,int y)
    //    {
    //        return func(x, y);
    //    }
    //    static void Main(string[] args)
    //    {
    //        var total = GetTotal((x, y) => { return x + y; }, 1.2m, 2);
    //        Console.WriteLine(total);
    //        Console.ReadLine();
    //    } 
    //}
    #endregion

    #region for循环
    /// <summary>
    /// for循环
    /// </summary>
    public class Program13
    {
        //static void Main(string[] args)
        //{
        //    for (int i = 1; i < 10; i++)
        //    {
        //        Console.WriteLine("下次一定认真");
        //        //Console.ReadLine();
        //    }
        //    Console.ReadLine();
        //}


        //static void Main(string[] args)
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        i = i + 1;
        //        Console.WriteLine(i);
        //    }
        //    Console.ReadLine();
        //}

        //    //for循环只有两个表达式
        //static void Main(string[] args)
        //{
        //    int money;
        //    int sum = 0;
        //    double avg = 0.0;
        //    Console.WriteLine("超市地址");
        //    string name = Console.ReadLine();
        //    int i = 0;
        //    for (;i<6;i++)
        //    {
        //        Console.WriteLine("请输入上半年" + (i + 1) + "个月的营业额");
        //        money = Convert.ToInt32(Console.ReadLine());
        //        sum += money;
        //        Console.WriteLine(name + "店铺前" + (i + 1) + "个月的总营业额是：" + sum);


        //    }
        //    Console.WriteLine(name + "的总金额是：" + sum);
        //    avg = sum / 6;
        //    Console.WriteLine(name + "的平均营业额是：" + avg);
        //}

        //    /// <summary>
        //    /// for循环没有判断表达式
        //    /// </summary>
        //    /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    int result = 0;
        //    for (int num=1; ;num++)
        //    {
        //        if (num>5)
        //        {
        //            break;
        //        }
        //        Console.WriteLine(num);
        //    }
        //    Console.ReadLine();
        //}

    }
    #endregion

    #region 乘法表
    /// <summary>
    /// 乘法表
    /// </summary>  
    //public class Program14
    //{
    //    //static void Main(string[] args)
    //    //{
    //    //    for (int i = 1; i <= 9; i++)
    //    //    {
    //    //        for (int j = 1; j <= 9; j++)
    //    //        {
    //    //            //Console.WriteLine("{0}*{1}={2:00}", i, j, i * j);//结果均占两位数
    //    //            Console.WriteLine("{0}*{1}={2}", i, j,i * j);
    //    //        }
    //    //    }
    //    //    Console.ReadLine();
    //    //}
    //    static void Main()
    //    {
    //        //梯形乘法表
    //        for (int i=1;i<=9;i++)
    //        {
    //            for (int j=1;j<=i; j++)
    //            {
    //                Console.WriteLine("{0}*{1}={2:00}",i,j,i*j);
    //            }
    //        }
    //    }
    //}

    #endregion

    #region 冒泡
    /// <summary>
    /// 冒泡
    /// </summary>  
    //public class Program15
    //{
    //    //static void Main(string[] args)
    //    //{
    //    //    int[] array = { 1, 4, 2, 9, 7, 6, 3, 5, 8 };
    //    //    for (int i = 0; i < array.Length; i++)
    //    //    {
    //    //        for (int j = 0; j < array.Length - i - 1; j++)
    //    //        {
    //    //            if (array[j] > array[j + 1])//根据下标取值，j==0时，下标是0，值是9.
    //    //            {
    //    //                int temp = array[j];
    //    //                array[j] = array[j + 1];
    //    //                array[j + 1] = temp;
    //    //            }
    //    //        }
    //    //    }
    //    //    Console.WriteLine("升序排序后的顺序：");
    //    //    foreach (int y in array)
    //    //    {

    //    //        Console.WriteLine(y + "");
    //    //    }
    //    //    Console.WriteLine();
    //    //    Console.ReadLine();
    //    //}

    //    //static void Main(string[] args)
    //    //{
    //    //    int[] array= { 1, 4, 2, 9, 7, 6, 3, 5, 8 };
    //    //    for (int i=0;i<array.Length;i++)
    //    //    {
    //    //        for (int j=0;j<array.Length-1;j++)
    //    //        {
    //    //            if (array[j]<array[j+1])
    //    //            {
    //    //                int temp = array[j];
    //    //                array[j] = array[j + 1];
    //    //                array[j + 1] = temp;
    //    //            }
    //    //        }
    //    //    }
    //    //    Console.WriteLine("降序排序顺序：");
    //    //    for (int i=0;i<array.Length;i++)
    //    //    {

    //    //        Console.WriteLine(array[i]);
    //    //    }
    //    //    Console.ReadKey();
    //    //}

    //    static void Main(string[] args)
    //    {
    //        int[] array = { 1, 4, 2, 9, 7, 6, 3, 5, 8 };
    //        Array.Sort(array);//升序
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            Console.WriteLine(array[i]);
    //        }
    //        Console.ReadLine();
    //    }
    //    //static void Main(string[] args)
    //    //{
    //    //    int[] array = { 1, 4, 2, 9, 7, 6, 3, 5, 8 };
    //    //    Array.Sort(array);
    //    //    Array.Reverse(array);//反转（Sort+Reverse为倒序）
    //    //    for (int i = 0; i < array.Length; i++)
    //    //    {
    //    //        Console.WriteLine(array[i]);
    //    //    }
    //    //    Console.ReadLine();
    //    //}
    //    //static void Main(string[] args)
    //    //{
    //    //    int[] array = { 1, 4, 2, 9, 7, 6, 3, 5, 8 };
    //    //    //array = array.OrderBy(x => x).ToArray();
    //    //    array = array.OrderByDescending(x => x).ToArray();
    //    //    for (int i = 0; i < array.Length; i++)
    //    //    {
    //    //        Console.WriteLine(array[i]);
    //    //    }
    //    //    Console.ReadLine();
    //    //}
    //}
    #endregion

    //    //switch
    //public class Program16
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("请选择编号：");
    //        int num = Convert.ToInt32(Console.ReadLine());
    //        switch (num)
    //        {
    //            case 1:
    //                Console.WriteLine("好");
    //                Console.ReadLine();
    //                break;
    //            case 2:
    //                Console.WriteLine("很好");
    //                Console.ReadLine();
    //                break;
    //            case 3:
    //                Console.WriteLine("非常好");
    //                break;
    //            default:
    //                Console.WriteLine("暂时只有这些信息");
    //                break;
    //        }
    //        Console.ReadLine();
    //    }
    //}

    ////substring
    //public class Program17
    //{
    //    static void Main(string[] args)
    //    {
    //        string content= "hello123";
    //        Console.WriteLine("substring(0)结果：" + content.Substring(2));
    //        Console.WriteLine("substring(0结果：)" + content.Substring(1, 5));
    //        Console.WriteLine("substring(0)结果：" + content.Substring(0, 7));
    //        Console.ReadLine();
    //    }
    //}

    //#region Split
    ////Split
    //public class Program18
    //{
    //    static void Main(string[] args)
    //    {
    //        string colors = "blue,yellow,orange,white,green";
    //        string[] arr1 = colors.Split(',');
    //        string[] arr2 = colors.Split(new char[] { ',' }, 3);//Split后面的都是第三个返回值
    //        Console.WriteLine("所有颜色：");
    //        for (int i = 0; i < arr1.Length; i++)
    //        {
    //            Console.WriteLine(arr1[i]);
    //        }
    //        Console.ReadLine();
    //        Console.WriteLine("前三个颜色：");
    //        for (int j = 0; j < arr2.Length; j++)
    //        {
    //            Console.WriteLine(arr2[j]);
    //        }
    //        Console.ReadLine();
    //    }
    //} 
    //#endregion

    //#region MD5加密
    ////MD5加密
    //public class Program19
    //{
    //    public static string Md5(string str)
    //    {
    //        MD5 md5 = new MD5CryptoServiceProvider();
    //        byte[] palindata = Encoding.Default.GetBytes(str);//将要加密的字符串转换为字节数组
    //        byte[] encryptData = md5.ComputeHash(palindata);//将字符串加密后也转换为字符数组
    //        string returnData = Convert.ToBase64String(encryptData);//将加密后的字节数组转换为加密字符串
    //        return returnData;
    //    }
    //    static void Main(string[] args)
    //    {

    //        Console.WriteLine("注册名称：");
    //        string name = "";
    //        name = Console.ReadLine();//和下面pass用法结果一样
    //        Console.WriteLine("注册密码：");
    //        string pass = Console.ReadLine();
    //        if (name != string.Empty && pass != string.Empty)
    //        {
    //            string data = Md5(pass);
    //            Console.WriteLine("注册成功");
    //            Console.WriteLine("已加密，加密结果：{0}", data);

    //        }
    //        else
    //        {
    //            Console.WriteLine("注册失败");
    //        }
    //        Console.ReadLine();

    //    }
    //}
    //#endregion



    //#region virtual重写
    //enum Gender
    //{
    //    雌 = 1,
    //    雄 = 1
    //}

    ///// <summary>
    ///// virtual重写
    ///// </summary>
    ////abstract class Bird//抽象类可用可不用
    //class Bird
    //{
    //    public string Name { set; get; }
    //    public Gender Gender { get; set; }
    //    public string ConsoleColor { get; set; }
    //    public virtual string Sleep()
    //    {
    //        return "睡觉";
    //    }
    //}
    //class Polly : Bird
    //{
    //    public override string Sleep()
    //    {
    //        //return base.Sleep();
    //        return "我要睡觉了";
    //    }
    //}
    //class Program21
    //{
    //    static void Main(string[] args)
    //    {
    //        Polly polly = new Polly();
    //        Console.WriteLine(polly.Sleep());
    //        Bird bird = new Bird();
    //        Console.WriteLine(bird.Sleep());
    //        Console.ReadLine();
    //    }
    //}
    //#endregion

    //#region abstract抽象类重写
    ///// <summary>
    ///// abstract抽象类重写
    ///// </summary> 
    //public class Program22
    //{
    //    static void Main(string[] args)
    //    {
    //        Chinese chinese = new Chinese();
    //        Console.WriteLine(chinese.SayHi());
    //        Console.ReadLine();
    //    }
    //}
    //abstract class Person
    //{
    //    public abstract string SayHi();
    //}
    //class Chinese : Person
    //{
    //    public override string SayHi()
    //    {
    //        return "中国人";
    //    }
    //} 
    //#endregion

    //#region 接口
    ///// <summary>
    ///// 接口
    ///// </summary>  
    //public class Bird
    //{
    //    public string Name { set; get; }
    //    public string ConsoleColor { get; set; }
    //}
    //public interface IFly
    //{
    //    string  Fly();
    //}
    //public interface IBird
    //{
    //    void Eat();
    //}
    //public class Aircraft : Bird, IFly, IBird
    //{
    //    public void Eat()
    //    {
    //        Bird bird = new Bird();
    //        //Console.WriteLine("减肥，不吃饭");
    //        Console.WriteLine(bird.Name);
    //    }

    //    public string  Fly()
    //    {
    //        return "飞一样的感觉";
    //    }
    //}
    //public class Program23
    //{
    //    static void Main(string[] args)
    //    {
    //        Aircraft aircraft = new Aircraft();

    //        Console.WriteLine(aircraft.Fly());
    //        Console.ReadLine();
    //    }
    //}
    //#endregion

    #region 数组
    /// <summary>
    /// 数组
    /// </summary>  
    //public class Program23
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] address = new string[3] { "河南", "海南", "云南" };
    //        Console.WriteLine("{0}、{1}", address[0], address[2]);
    //        Console.ReadLine();
    //    }

    //}
    //public class Program24
    //{
    //    static void Main(string[] arg)
    //    {
    //        double[] score = new double[5];
    //        for (int i=0;i<score.Length;i++)
    //        {
    //            Console.WriteLine("请输入第{0}位同学的考试成绩：", i+1 );
    //            score[i] = Convert.ToDouble(Console.ReadLine());

    //        }
    //        Console.WriteLine();
    //        Console.WriteLine("第一位同学的成绩：{0}", score[0]);
    //        Console.WriteLine("第五位同学的成绩：{0}", score[4]);
    //        Console.WriteLine("最后一位同学的成绩：{0}", score[score.Length-1]);
    //        Console.ReadLine();
    //    }
    //} 


    //    //二维数组
    //public class Program25
    //{
    //    static void Main(string[] args)
    //    {
    //        string[,] name = new string[3, 4]
    //        {
    //           { "一人","一行","一粥","一饭" },
    //           {"两人","两行","两粥","两饭" },
    //            {"三人","三行","三粥","三饭" }
    //        };
    //        Console.WriteLine("第二行第一列的值：{0}", name[1, 0]);
    //        Console.ReadLine();
    //    }
    //}

    //#region Math
    ////Math
    //public class Program26
    //{
    //    static void Main(string[] args)
    //    {
    //        ////Console.WriteLine("E的常量：{0}" , Math.E);
    //        //Console.WriteLine("E的常量：" + Math.E);
    //        //Console.ReadLine();
    //        //Console.WriteLine("10和20的最大值：" + Math.Max(10, 20));
    //        //Console.WriteLine("1.3和2.5的最小值：" + Math.Min(1.3, 2.5));
    //        //Console.WriteLine("-1的绝对值："+Math.Abs(-1)); 
    //        Console.ReadLine();

    //    }
    //} 
    //#endregion

    #region 哈希
    /// <summary>
    /// 哈希
    /// </summary>  
    //public class Program27
    //{
    //    static void Main(string[] args)
    //    {
    //        Hashtable ht = new Hashtable();
    //        ht.Add("1001", "旺仔");
    //        ht.Add("1002", "棉花糖");
    //        //string num = "";
    //        string name = "";
    //        Console.WriteLine("hash中有{0}件商品", ht.Count);

    //    gotoName:
    //        Console.WriteLine("请输入添加的商品编号：");
    //        string num = Console.ReadLine();
    //        if (ht.Contains(num))
    //        {
    //            Console.WriteLine("商品编号已经存在，请更换编号");
    //            goto gotoName;
    //        }
    //        Console.WriteLine("请输入添加的商品名称：");
    //        //string name = Console.ReadLine();
    //        ht.Add(num, name);
    //        Console.WriteLine("************");
    //        Console.WriteLine("添加商品成功，目前hash对象中有{0}件商品。", ht.Count);
    //        Console.ReadLine();
    //    }

    //}

    #endregion

    public class Pragram28
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1001", "方便面");
            ht.Add("1002", "火腿肠");
            Console.WriteLine("获取哈希集合的键");
            foreach(string key in ht.Keys)
            {
                Console.WriteLine("商品编号：{0}", key);
            }
            Console.WriteLine("获取哈希集合的值");
            foreach(string value in ht.Values)
            {
                Console.WriteLine("商品名称：{0}", value);
            }
            Console.WriteLine("获取哈希的键值");
            foreach (string item in ht.Keys)
            {
                Console.WriteLine("商品编号{0},商品名称{1}", item, ht[item]);
                Console.ReadLine();
            }
        }
    }
    #endregion
}
