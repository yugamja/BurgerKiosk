# (C샵 코딩) 버거 키오스크

## 개요
- C# 프로그래밍 학습
- 1줄 소개: 버거와 추가옵션을 원하는 대로 주문하고 총 금액을 확인할 수 있는 프로그램
- 사용한 플랫폼: 
	- C#, .Net Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤: 
	- Label, RadioButton, CheckBox, GroupBox, ListBox, Button, PictureBox
- 사용한 기술과 구현한 기능: 
	- 처음 실행 화면에서 햄버거 종류 radiobutton 하나가 미리 선택되어 있는 상황을 제거함. -> formload에서 checked False
	- 각 메뉴의 값을 설정하고 사용자가 선택하면 totalCost 변수에 값이 더해져 '주문하기' 버튼을 누르면 lblToalCost에 총 합계가 뜨도록 함. 동시에 선택한 각 메뉴들과 그 금액이 lstOrder에 표시되도록 함.
	- 아무것도 선택하지 않고 주문하기 버튼을 누르면 에러 메시지 "메뉴를 선택하세요" 표시 -> lblTotalCost.Text를 사용해 MessageBox가 아닌 Label에 표시되도록 함. 동시에 lblTotalCost.ForeColor를 사용해 라벨의 색상을 바꾸어 가독성을 키움.
	- Tab을 이용해서 GroupBox 사이를 이동하기 
	- 방향키를 이용해서 선택 아이템 사이를 이동하기 (windows form 기본 기능이었음)
	- 스페이스바를 이용해서 아이템 선택하기 (기본 기능이었음)
	- this.AcceptButton을 사용해 Enter키로 '주문하기'(btn_order) 누르기
	- RadioButton과 CheckBox에서 메뉴를 선택하면 바로 그 정보들이 ListBox에 업데이트 되도록 함




## 실행화면 (과제1)
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/task1.png)

- 구현한 내용 (위 그림 참조)
	- 전체적인 UI 설정을 함.  Label, RadioButton, CheckBox, GroupBox, ListBox, Button, PictureBox 컨트롤을 배치함.
	- 처음 실행 화면에서 햄버거 종류 radiobutton 하나가 미리 선택되어 있는 상황을 제거함. -> formload에서 checked False
	- 각 메뉴의 값을 설정하고 사용자가 선택하면 totalCost 변수에 값이 더해져 '주문하기' 버튼을 누르면 lblToalCost에 총 합계가 뜨도록 함. 동시에 선택한 각 메뉴들과 그 금액이 lstOrder에 표시되도록 함.



## 실행화면 (과제2)
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/task2.png)

- 구현한 내용 (위 그림 참조)
	- 아무것도 선택하지 않고 주문하기 버튼을 누르면 에러 메시지 "메뉴를 선택하세요" 표시 -> lblTotalCost.Text를 사용해 MessageBox가 아닌 Label에 표시되도록 함. 동시에 lblTotalCost.ForeColor를 사용해 라벨의 색상을 바꾸어 가독성을 키움.



## 실행화면 (과제3)
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/task3.png)

- 구현한 내용 (위 그림 참조)
	- Tab을 이용해서 GroupBox 사이를 이동하기 -> RadioButton과 CheckButton만 Tab이 실행되도록 하기 위해 그 외의 것들은 TabStop = false 처리를 함. 그러나 RadioButton에 Tab키가 안 적용되는 어려움이 있었지만 KeyDown에서 RadioButton에 포커스가 맞춰지도록 설정하며 극복함
	- 방향키를 이용해서 선택 아이템 사이를 이동하기
	- 스페이스바를 이용해서 아이템 선택하기
	- Enter키로 버튼을 누르기 -> this.AcceptButton를 사용해 엔터키로 '주문하기'버튼이 실행 가능하도록 함



## 실행화면 (과제4)
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/task4.png)

- 구현한 내용 (위 그림 참조)
	- RadioButton과 CheckBox에서 원하는 항목을 선택하면 그 즉시 정보들이 업데이트 되도록 함 -> lstOrder에 입력되고 동시에 TotalCost 변수 값이 업데이트 되는 UpdateList() 함수를 직접 만들어 구현함 (if-else문과 lstOrder.Items.Add를 사용함)



