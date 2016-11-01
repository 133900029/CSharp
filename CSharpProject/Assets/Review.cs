using UnityEngine;
using System.Collections;

public class Review : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}







// 
// 
// 公共语言运行时Common Language runtime//管理代码，保证正确
// 通用类型系统  Common Type System//通过装箱和拆箱实现无缝互操作
// 公共语言规范  Common Language Specification//最低标准
// 
// const int value = 10;
// 
// public
// internal只在当前项目使用
// abstract
// sealed不能被继承
// 
// 静态构造函数只执行一次
// 
// 索引器
// class Person
// {
//    private int[] intArray = new int[10];
//    public int this[int index]
//     {
// 	get set
//     }
// }
// 
// 类是引用类型
// 结构体是值类型，可以不用new
// 
// 封装：把客观事物封成类，并把内部实现隐藏，保证数据完整性
// 继承：复用父类代码
// 多态：将子类赋值给父类的能力
// 
// virtual
// abstract
// override
// base
// new
// 
// 类和类是属于的关系
// 类和接口是can do的关系
// 类不能多继承，接口可以多继承
// 
// 委托
// public delegate void Write(string name)
// public Wrtie write
// 事件
// public delegate void Write(string name)
// public event Write write
// C#自带
// public delegate void EventHandler(object sender,EventArgs e)
// MarryEventArgs : EventArgs  string message
// 
// 委托能够直接使用，能够类外使用
// 事件不能直接使用，不能类外使用
// 
// 事件是一个特殊的委托

// 值被分配到线程的堆栈，变量保存数据
// 引用被分配到托管堆，变量保存数据的内存地址
// 
// 无论是值变量还是引用变量，变量本身都存在栈上
// 
// 值和引用的转换-装箱和拆箱
// 
// 值类型值传递--值不收影响
// 引用类型值传递--值受影响
// 
// 值类型引用传递--值变--out ref
// 引用类型引用传递--值变--out ref
// 
// 泛型
// class A<T> where T :class
// 
// 可空类型
// Nullable<int> value = 1;
// int? value = 1;
// int y = value ?? 123;
// 
// 匿名方法
// method.Onclick=()=>{}
// 
// 迭代器
// 继承IEnumerable 能够迭代
// 实现IEnumerator GetEnumerator方法
// 
// 自动属性
// public string Name{set;get;}
// 
// 隐式类型
// var
// 
// lambda表达式
// => 等价于 goto
// 树的表达式
// 
// 扩展方法
// public static JSM(this IEnumerable<int> source)
// 
// linq
// from item in collection where item%2 ==0 select item
// 
// 可选参数
// (int x=10, int y)
// 
// 动态类型
// dynamic i =10;









