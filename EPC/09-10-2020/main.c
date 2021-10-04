#include <stdio.h>
#include <stdlib.h>
#include <math.h> 

//stdio = standard input / output
//standard library, h = header
//int = integer = so nguyen

int sum2Numbers(int x, int y){
	//than ham = block	
	return x + y;
}
//check odd or even ?
void checkEvenNumber() {
	int numberA;//an integer variable
	printf("Enter an integer number:\n"); scanf("%d", &numberA);
	int remains = numberA % 2;
	if(remains == 0) {
		printf("This is even");
	} else {
		printf("This is odd");
	}
}
void chepPhat() {
	int count = 1;
	while(count <= 1000) {
		printf("I say hello - %d \n", count);
		count = count + 1;
	}
	printf("Chep phat xong");
}
void solve() {
	double a,b,c;
	double x1,x2,x;
	double delta;
	printf("Enter a = "); scanf("%lf", &a); 
	//lf = long float = "double"
	printf("Enter b = "); scanf("%lf", &b);
	printf("Enter c = "); scanf("%lf", &c);
	if(a == 0.0) {
		printf("You must enter a > 0");
		return;
	}
	delta = b * b - 4 * a * c;	
	printf("haha = %f", delta);
	if(delta > 0){
		printf("Hai nghiem phan biet \n");
		//sqrt = squared root
		x1 = (-b + sqrt(delta)) / (2 * a);
		x2 = (-b - sqrt(delta)) / (2 * a);
		printf("x1 = %0.2f \n", x1);
		printf("x2 = %0.2f \n", x2);
	} else if(delta == 0) {
		printf("One result \n");
		x = -b / (2 * a);
		printf("x=%0.2fabcd \n", x);
	} else {
		printf("No result \n");
	}
}

int main(int argc, char *argv[]) {
	solve();
	return 0;	
	chepPhat();
	//Goi ham tinh tong hai so 
	printf("Chuong trinh tinh tong 2 so\n");//\n = returN
	int sum = sum2Numbers(1,4);
	//In ket qua ra man hinh
	printf("Tong 2 so la : %d", sum);
	//Lenh gan == assign
	int x = 100;
	int y = 200;
	x = x + 1;
	printf("Gia tri cua x = %d",x);
	checkEvenNumber();
	return 0;		
} 
