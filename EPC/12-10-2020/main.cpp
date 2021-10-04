#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
using namespace std;

//tinh chu vi
float getPerimeter(float radius) {
	return 2 * M_PI * radius;	
}

float getArea(float radius) {
	return pow(radius, 2) * M_PI; //pow = power
}
float convertCelciusToFarenheit(float celcius)  {
	//convert_celcius_to_farenheit => c, python, ruby, php
	//convertCelciusToFarenheit => c, java, c#, Swift,..
	//convert_CelciusTo_Fa => don't do this !
	return celcius * (9.00/5.00) + 32.0;
}
void calculateMarks() {
	double math, physics, chemistry, biology;
	double sum, average;
	printf("Enter math : "); scanf("%lf", &math);
	printf("Enter physics : "); scanf("%lf", &physics);
	printf("Enter chemistry : "); scanf("%lf", &chemistry);
	printf("Enter biology : "); scanf("%lf", &biology);
	sum = math + physics + chemistry + biology;
	average = sum / 4.00;
	printf("sum = %0.2lf, average = %0.2lf\n", sum, average);
}
void doSomething() {
	float x;//0.0
	printf("value of x = %f\n", x);
	printf("address of x = %p\n", &x);
	//khac nhau giua string va char(character)
	char choice = 'y';//this is a char
	//char name[200];//string
	string myname = "Hoang";
	cout<<"Your name is :"<<myname<<endl;

}

int main(int argc, char *argv[]) {
	doSomething();
	return 0;
	calculateMarks();	
	float celcius, farenheit;
	cout<<"Enter celcius :"<<endl;
	cin>>celcius;
	farenheit = convertCelciusToFarenheit(celcius);
	cout<<"Farenheit = "<<farenheit;
	
	float radius;//gia tri la 0.0
	printf("Enter radius : "); scanf("%f", &radius);
	//Goi ham va tinh toan
	float perimeter = getPerimeter(radius);
	//Hien thi chu vi	
	float area = getArea(radius);
	printf("Perimeter is : %0.2f, \n Area is : %0.2f", perimeter, area);
	//string format/interpolation/template
	float age, salary;
	printf("Enter your age : "); scanf("%f", &age);
	printf("Enter your salary : "); scanf("%f", &salary);
	printf("Your salary is : %0.2f, your age is: %0.2f\n", salary, age);
	cout<<"Your salary is "<<salary<<", your age is: "<<age<<endl;
	
	
	return 0;
}
