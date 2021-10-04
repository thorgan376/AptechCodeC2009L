#include <stdio.h>
#include <stdlib.h>
#include <string.h>
struct Song {
	char title[30];
	char genre[30];
	unsigned int release_year;
	float price;
};
int numberOfSongs;
void input(struct Song* songs) {
	int i;
	for(i = 0; i < numberOfSongs; i++){
		struct Song* eachSong = songs + i;
		printf("Song number %d : \n", i+1);		
		printf("Enter title: \n"); scanf("%s", &(eachSong->title));//lat nua thu ->
		printf("Enter genre: \n"); scanf("%s", &(eachSong->genre));
		printf("release_year: \n"); scanf("%d", &(eachSong->release_year));		
	}
}

void printData(struct Song* songs) {
	int i;
	for(i = 0; i < numberOfSongs; i++){
		struct Song eachSong = *(songs + i);
		printf("Song number %d : \n", i+1);
		printf("Title: %s\n", eachSong.title);
		printf("Genre: %s\n", eachSong.genre);
		printf("release_year: %d\n", eachSong.release_year);
		printf("price: %f\n", eachSong.price); 
	}
}
void sort(){
	printf("Sort\n");
}
void analyze(){
	printf("Analyze\n");
}
void find(){
	printf("Find\n");
}
void save(){
	printf("Save\n");
}
void open(){
	printf("Open\n");
}

void createMenu() {
	printf("+------------------------------------------------------------------+\n");	
	printf("|				 MUSIC STORE MANAGEMENT PROGRAM					   |\n");	
	printf("|1. Input |2. Sort |3. Analyze |4. Find |5. Save |6. Open |7. Exit |\n");	
	printf("+------------------------------------------------------------------+\n");	
	char choice;	
	struct Song* songs;
	printf("Your choice:\n");		
	choice = getchar();
	while(choice == '\n'){
		choice = getchar();		
	}
	while(choice != '7') {
		switch(choice) {			
			case '1':
				printf("How many songs ?\n"); scanf("%d", &numberOfSongs);
				songs = (struct Song*)malloc(numberOfSongs * sizeof(struct Song*));
				input(songs);
				printData(songs);
				break;
			case '2':
				sort();
				break;
			case '3':
				analyze();
				break;
			case '4':
				find();
				break;
			case '5':
				save();
				break;
			case '6':
				open();
				break;
			default:
				break;
		}
		printf("Do you want to continue ?\n");
		printf("- Yes, I do. (press y, Y)\n");
		printf("- No, I don't. (press n, N\n");
		printf("- Please clear the screen ! (press c, C)\n");
		printf("Your choice:\n");		
		choice = getchar();
		while(choice == '\n'){
			choice = getchar();
		}
		if(choice == 'n' || choice == 'N') {
			printf("Program ended...\n");
			break;
		} else if(choice == 'c' || choice == 'C') {
			system("@cls||clear");			
		}

	}

}
int main() {
	createMenu();
}

