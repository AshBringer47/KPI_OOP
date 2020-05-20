#include <iostream>
#include "LinkedList.h"

using namespace std;

int main() {
	cout << "Gunawardana Shiron. IS92\n";
	LinkedList list = LinkedList(); // Создаём объект типа список.
	list.Push(5); // Добавляем элемент 5 в начало.
	list.Push(7); // Добавляем элемент 7 в начало.
	list.Push(6); // Добавляем элемент 6 в начало.
	list.Print(); // Выводим список.
	list.MoreThanMeanRemove(); // Удаляём все значения, большие чем среднее.
	list.Print(); // Выводим модифицированый список.
	return 0;
}