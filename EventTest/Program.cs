﻿using DotNetEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    class Program
    {

        static void Main(string[] args)
        {
            ProgramTest test = new ProgramTest();
            test.Main();

            A a = new A(); // 定义首领A

            B b = new B(a); // 定义部下B

            C c = new C(a); // 定义部下C

            // 首领A左手举杯
            a.Raise("左");

            // 首领A右手举杯
            //a.Raise("右");

            // 首领A摔杯
            //a.Fall();

            Console.ReadLine();
            // 由于B和C订阅了A的事件，所以无需任何代码，B和C均会按照约定进行动作。
        }
    }


    /// <summary>
    /// 委托的三种方式   声明委托，创建委托的方法，实例化委托，委托调用
    /// </summary>
    public class TestDelegate
    {
        // namespace a delegate
        delegate void Del(int num);
        // create a method
        public  void DelMethod(int num)
        {

        }

        // instantiate a delegate
        public void InvokeMethod()
        {
            Del del = DelMethod;
            del(123123);

            Del dels = delegate (int num)
            {

            };

            ((Del)delegate (int num)
                        {

                        })(11);


            Del del2 = x => { };
            del2(1232);
        
        }
    }

    /// <summary>
    /// 首领A举杯委托
    /// </summary>
    /// <param name="hand">手：左、右</param>
    public delegate void RaiseEventHandler(string hand);
    /// <summary>
    /// 首领A摔杯委托
    /// </summary>
    public delegate void FallEventHandler();
    /// <summary>
    /// 首领A
    /// </summary>
    public class A
    {
        /// <summary>
        /// 首领A举杯事件
        /// </summary>
        public event RaiseEventHandler RaiseEvent;
        /// <summary>
        /// 首领A摔杯事件
        /// </summary>
        public event FallEventHandler FallEvent;

        /// <summary>
        /// 举杯
        /// </summary>
        /// <param name="hand">手：左、右</param>
        public void Raise(string hand)
        {
            Console.WriteLine("首领A{0}手举杯", hand);
            // 调用举杯事件，传入左或右手作为参数
            if (RaiseEvent != null)
            {
                RaiseEvent(hand);
            }
        }
        /// <summary>
        /// 摔杯
        /// </summary>
        public void Fall()
        {
            Console.WriteLine("首领A摔杯");
            // 调用摔杯事件
            if (FallEvent != null)
            {
                FallEvent();
            }
        }
    }
    /// <summary>
    /// 部下B
    /// </summary>
    public class B
    {
        A a;

        public B(A a)
        {
            this.a = a;
            a.RaiseEvent += new RaiseEventHandler(a_RaiseEvent); // 订阅举杯事件
            a.FallEvent += new FallEventHandler(a_FallEvent); // 订阅摔杯事件


            a.RaiseEvent +=(e)=>
            {

            };
        }
        /// <summary>
        /// 首领举杯时的动作
        /// </summary>
        /// <param name="hand">若首领A左手举杯，则B攻击</param>
        void a_RaiseEvent(string hand)
        {
            if (hand.Equals("左"))
            {
                Attack();
            }
        }

        /// <summary>
        /// 首领摔杯时的动作
        /// </summary>
        void a_FallEvent()
        {
            Attack();
        }

        /// <summary>
        /// 攻击
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("部下B发起攻击，大喊：猛人张飞来也！");
        }
    }
    /// <summary>
    /// 部下C
    /// </summary>
    public class C
    {
        A a;
        public C(A a)
        {
            this.a = a;
            a.RaiseEvent += new RaiseEventHandler(a_RaiseEvent); // 订阅举杯事件
            a.FallEvent += new FallEventHandler(a_FallEvent); // 订阅摔杯事件
        }
        /// <summary>
        /// 首领举杯时的动作
        /// </summary>
        /// <param name="hand">若首领A右手举杯，则攻击</param>
        void a_RaiseEvent(string hand)
        {
            if (hand.Equals("右"))
            {
                Attack();
            }
        }

        /// <summary>
        /// 首领摔杯时的动作
        /// </summary>
        void a_FallEvent()
        {
            Attack();
        }
        /// <summary>
        /// 攻击
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("部下C发起攻击，一套落英神掌打得虎虎生威~");
        }
    }
}