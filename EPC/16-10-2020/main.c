#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <limits.h>
#include <conio.h>
int x, y;

char getInputOneCharacter() {
	char choice;
	choice = getchar();
	while(choice == '\n') {
		choice = getchar();		
	}
	
	return choice;
}
void sum() {			
	printf("x = "); scanf("%d", &x);
	printf("y = "); scanf("%d", &y);
	printf("Tong = %d", x + y);
}
void minus() {			
	printf("x = "); scanf("%d", &x);
	printf("y = "); scanf("%d", &y);
	printf("Hieu = %d", abs(x - y)); //abs = absolute = lay gia tri tuyet doi
}
void createMenu() {
	char choice;	
	while(choice != 'c' && choice != 'C' && choice != '3') {
		printf("1.Tinh tong\n");
		printf("2.Tinh hieu\n");			
		printf("3.Ket thuc\n");			
		printf("Moi ban chon 1,2,3:\n");
		choice = getInputOneCharacter();
		switch(choice) {
			case '1':
				printf("1.Tinh tong\n");
				sum();
				break;
			case '2':
				printf("2.Tinh hieu\n");	
				minus();		
				break;
			case '3':
				printf("3.Ket thuc\n");							
				break;
			default:
				break;
		}
		if(choice == '3'){
			continue;
		}
		printf("Ban co muon ket thuc(c,k) ?\n");
		choice = getInputOneCharacter();
		printf("haha");
	}
	printf("Chuong trinh da ket thuc\n");
}
int main(){	
	//chua noi gi den tinh toan, hay lam menu da
	//Cast = ep kieu
	//Ep tu nho sang to
	printf("\n%d\n", INT_MAX);
    printf("%d\n", INT_MIN);
    
	int x = 10;
	float bigX = x;
	printf("bigX = %f", bigX);//ok, always success
			    
	float bigY = 2147483649;
	int y = bigY;
	printf("y = %d", y);//not always success
	printf("Humidity is 68%%");
	printf("Special char is \"");
	int a = 2147483649;
	printf("a = %hd", a);
	//tim hieu ve string = xau ky tu = array of char
	char stringA[250];
	strcpy(stringA, "Hoang");
	char stringB[250];
	strcpy(stringB, stringA);
	
	if(strcmp("Hoang", "Kien") > 0) {
		printf("\n11111");
	} else {
		printf("\n22222");
	}
	//iterate an array	
	int someNumbers[4] = {3, 9, 8, 99} ;
	int i;
	for(i = 0; i < 4; i++) {
		printf("\nphan tu thu %d la : %d\n", i,someNumbers[i]);
	}
	int N;
	//Nhap N so thuc(floaf) tu ban phim, sau do hien ra
	//va luu vao array
	printf("Nhap N ="); scanf("%d", &N);
	float someFloats[N];
	for (i = 0; i < N; i++){
		printf("Phan tu so %d", i);
		scanf("%d", &someFloats[i]);
	}
	return 0;	
	
}

