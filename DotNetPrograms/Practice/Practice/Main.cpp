#include<iostream>
using namespace std;
class A
{
public:
	virtual void fun(void)
	{
		cout << "A::fun()" << endl;
	}
	virtual void fun1()
	{
		cout << "A::fun1()" << endl;
	}
	void fun2()
	{
		cout << "A::fun2()" << endl;
	}
	virtual void fun3()
	{
		cout << "A::fun3()" << endl;
	}
	void fun4()
	{
		cout << "A::fun4()" << endl;
	}
};
class B:public A
{
public:
	virtual void fun(void)
	{
		cout << "B::fun()" << endl;
	}
	void fun1()
	{
		cout << "B::fun1()" << endl;
	}
	virtual void fun2()
	{
		cout << "B::fun2()" << endl;
	}
	
	void fun4()
	{
		cout << "B::fun4()" << endl;
	}
	virtual void fun5()
	{
		cout << "B::fun5()" << endl;
	}
};
int main(void)
{
	A* ptr = new B();
	ptr->fun();
}