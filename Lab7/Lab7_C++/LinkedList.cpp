#include "LinkedList.h"
#include <iostream>

LinkedList::LinkedList() {
	_head = nullptr; // При создании списка - он пустой, следовательно верхний элемент имеет пустой указатель.
	_size = 0;
}

void LinkedList::Push(short data) {
	_head = new Node(data, _head); // При добавлении элемента в начало, мы создаём новый объект типа Node и делаем его верхним.
	_size++;
}

LinkedList::Node::Node(short data, Node* pNext = nullptr) {
	this->data = data; // Поле data хранит в себе значение указателя.
	this->pNext = pNext; // Поле pNext хранит в себе указатель на следующий элемент.
}

int LinkedList::Size() {
	return _size;
}

short& LinkedList::operator[](const int index) {
	int counter = 0;
	Node* current = this->_head;
	while (current != nullptr) {
		if (counter == index)
			return current->data;
		current = current->pNext;
		counter++;
	}
}

int LinkedList::ThreeDivided() {
	int counter = 0;
	Node* current = this->_head; // Первым элементом - выбираем самый верхний.
	while (current != nullptr) {
		counter = (current->data % 3 == 0) ? ++counter : counter;
		current = current->pNext; // Переходим к следующему указателю.
	}		
	return counter;
}

double LinkedList::Mean() {
	double sum = 0;
	Node* current = this->_head;
	while (current != nullptr) {
		sum += current->data;
		current = current->pNext;
	}
	return sum / this->_size;
}

void LinkedList::MoreThanMeanRemove() {
	double Mean = this->Mean();
	Node* current = this->_head;
	int counter = 0;
	while (current != nullptr) {
		if (current->data > Mean) {
			current = current->pNext;
			RemoveAt(counter);
			continue;
		}
		counter++;
		current = current->pNext;
	}
}

void LinkedList::RemoveAt(int index) {
	if (index == 0)
		this->PopFront();
	else {
		Node* previous = this->_head;
		for (auto i = 0; i < index - 1; i++) 
			previous = previous->pNext;		
		Node* temp = previous->pNext;
		previous->pNext = temp->pNext;
		delete temp;
		_size--;
	}
}

void LinkedList::PopFront() {
	Node* temp = this->_head; // Создаём временную переменную, которая хранит в себе указатель на верхний элемент.
	_head = _head->pNext; // Перемещаем указатель на верхний элемент на следующий элемент.
	delete temp; // Очищаем память, от начального верхнего элемента.
	_size--; // уменьшаем размер массива.
}

void LinkedList::Print() {
	std::cout << "Your list: ";
	for (int i = 0; i < this->_size; i++) {
		std::cout << this->operator[](i);
		if (i == this->_size- 1)
			std::cout << "\n";
		else
			std::cout << "->";
	}
}
