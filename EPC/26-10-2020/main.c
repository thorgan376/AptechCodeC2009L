#include <stdio.h>
#include <string.h>
#include <stdlib.h>

//a struct => fields
struct Mobile {
	char name[200];//field = truong = attribute = property
	unsigned int year;
	char osName[150];
	char producer[300];
	double price;
};
//list of point
struct Point {
	float x;
	float y;
};

struct Mobile mobiles[10];//list of mobile
int numberOfMobiles;
void testSomeStructs() {
	struct Mobile iphone5C;
	struct Mobile iphone7;
	struct Mobile huaweiABC;	
	//change data

	//iphone5C.name = "iphone 5C";//not work !
	strcpy(iphone5C.name, "iphone 5C");
	iphone5C.year = 2015;
	strcpy(iphone5C.producer, "Apple");	
	iphone5C.price = 550;
	printf("Name = %s, year = %d, producer = %s, price = %0.0lf\n",
			iphone5C.name, iphone5C.year, iphone5C.producer, iphone5C.price
		);
	printf("Memory address of iphone5C = %p\n", &iphone5C);

	strcpy(iphone7.name, "iphone 7");
	iphone7.year = 2017;
	strcpy(iphone7.producer, "Apple");	
	iphone7.price = 700;
	printf("Name = %s, year = %d, producer = %s, price = %0.0lf\n",
			iphone7.name, iphone7.year, iphone7.producer, iphone7.price
		);
	printf("Memory address of iphone7 = %p\n", &iphone7);
}

void inputSomeMobiles() {
	int i;
	printf("How many mobiles ? ");scanf("%d", &numberOfMobiles);
	for(i = 0; i < numberOfMobiles; i++) {
		//Khoi tao 1 doi tuong mobile
		struct Mobile newMobile;	
		printf("Enter name: ");scanf("%s", &newMobile.name);
		printf("Enter year: ");scanf("%d", &newMobile.year);		
		printf("Enter producer: ");scanf("%s", &newMobile.producer);
		printf("Enter price: ");scanf("%lf", &newMobile.price);
		mobiles[i] = newMobile;
	}
}
void showListOfMobiles() {
	//Show list of mobiles:
	int i;
	for(i = 0; i < numberOfMobiles; i++) { 		
		printf("Name = %s, year = %d, producer = %s, price = %0.0lf\n",
			mobiles[i].name, mobiles[i].year, mobiles[i].producer, mobiles[i].price
		);
	}
}
int sum(int* x, int* y) {
	return *x + *y;
}


void doSomething(int* z) { //call by reference
	printf("Address of z is : %p\n", z);
	*z = 222;		
}
void sum2NumbersUsingPointer() {
	//Pointer basics
	int* x = (int *)malloc(2 * sizeof(int));
	printf("\nAddress of x is : %p", x);
	*x = 12;
	*(x + 1) = 333;
	//Must allocate data("memory allocation")	
	printf("Value of x is : %d \n", *x);
	printf("Value of x(aside) is : %d\n", *(x+1));
	int* a = (int*)malloc(sizeof(int));
	int* b = (int*)malloc(sizeof(int));
	printf("Enter a = ");scanf("%d", a);
	printf("Enter b = ");scanf("%d", b);
	printf("Sum 2 and 3 is : %d", sum(a, b));
}
int main(int argc, char *argv[]) {
	//testSomeStructs();
	// inputSomeMobiles();
	// showListOfMobiles();
	//sum2NumbersUsingPointer();	
	int z = 111;
	printf("Address of z is : %p\n", &z);
	doSomething(&z);
	printf("z = %d\n", z);
	float a = 120;
	float* b = &a;	
	float* c = b;	
	printf("\naddress of a = %p", &a);
	// printf("value AT b = %f", *b);
	//b = NULL;
	//printf("\nvalue of b = %p", b);	
	printf("\nvalue of c = %p\n", c);
	*b = 333;
	printf("value of a = %f", a); //333 ?
	return 0;
}

