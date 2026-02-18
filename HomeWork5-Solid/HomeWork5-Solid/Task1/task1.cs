using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HomeWork5_Solid.Task1
{
	//DIP – Dependency Inversion Principle
	//ماژول‌های سطح بالا نباید به ماژول‌های سطح پایین وابسته باشند؛
	// هردو باید به Abstraction(interface / abstract class) وابسته باشند	
	//OrderService → IOrderRepository ← SqlOrderRepository



	//IoC – Inversion of Control
	//کنترل ساخت و مدیریت وابستگی‌ها از داخل کد ما خارج می‌شود و به یک موجودیت دیگر سپرده می‌شود.
	//و خودت new نکن، یکی دیگه برات بسازه
	//var service = container.GetService<OrderService>();


	//IoC Container
	//	تعریف
	//	ابزاری که:
	//	وابستگی‌ها را می‌سازد
	//	تزریق می‌کند
	//	عمر(Lifetime) آن‌ها را مدیریت می‌کند

	//	مثال‌ها:
	//	Microsoft.Extensions.DependencyInjection
	//	Autofac
	//	Ninject


	//Factory as IoC Container
	//public class ServiceFactory
	//{
	//	public static IOrderRepository Create()
	//	{
	//		return new SqlOrderRepository();
	//	}
	//}


	//Dependency Injection (DI)
	//	تعریف
	//تزریق وابستگی‌ها به جای ساختن آن‌ها در داخل کلاس
	//انواع DI:
	//Constructor Injection
	//Property Injection
	//Method Injection



	//Service Lifetimes در .NET
	//Transient (هر بار درخواست → یک نمونه جدید)
	//Scoped (در هر Request یک نمونه)
	//Singleton

}
