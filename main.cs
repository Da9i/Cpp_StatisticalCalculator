#include<iostream>
using namespace std;
int main()
{
	int arr[10];
	cout << "ENTER THE NUMBERS : " << endl;
	for (int i = 0; i < 10; ++i)

		cin >> arr[i];
	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			if (arr[i] < arr[j])
			{
				int temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
			}
		}
	}
	int count = 1, index, temp = 0, i = 0;
	for (int k = 0; k < 10; k++)
	{
		for (int j = 0; j < 10; j++)
		{
			if (arr[k] == arr[j])
			{
				temp++;
			}
		}
		if (count < temp)
		{
			count = temp;
			index = k;
		}
		temp = 0;
	}
	if (count > 1)
		cout << "MODE=" << arr[index] << endl;
	else
		cout << "No Mode:" << endl;
	cout << "MEDIAN=" << (10 + 1) / 2 << endl;
	int sum = 0;
	for (int i = 0; i < 10; i++)
		sum += arr[i];
	cout << "Mean=" << sum / 10 << endl;
	cout << "MIN value =" << arr[0] << "MAX value=" << arr[9] << endl;
	cout << "DECENDING ORDER: ";
	for (int i = 9; i >= 0; i--)
		cout << arr[i] << " ";
	system("pause>0");
}
