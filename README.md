# Lab7_Button_Color
Практическая работа №7

Приложение "Убегающая кнопка"
Суть приложения состоит в том, что пользователю предлагается окно, содержащее кнопку.
Цель пользователя - нажать на кнопку. Приложение должно не дать пользователю нажать
на кнопку.
Интерфейс приложения
Требования к приложению
1. При открытии приложения кнопка позиционируется по центру окна.
2. Окно приложения поддерживает изменение размеров.
3. Окно приложения поддерживает сворачивание на панель задач.
4. Окно приложения поддерживает разворачивание на весь экран.
5. При изменении размеров окна, кнопка изменяет своё положение пропорционально
направлению изменения размеров окна.
6. Кнопка не может выйти за пределы окна.
7. При движении мышки в направлении кнопки, кнопка перемещается в сторону,
противоположную движению мыши с ускорением, пропорциональным скорости
движения курсора мыши.
8. При успешном нажатии на кнопку, приложение открывает диалоговое окно,
содержащее сообщение: "Поздравляем! Вы смогли нажать на кнопку!".
Приложение "Цветовая палитра"
Приложение представляет собой инструмент, позволяющий пользователю выбирать цвет,
с использованием графического пользовательского интерфейса.
Интерфейс приложения
Требования к приложению
Элемент управления, представляющий собой прямоугольную область, используемую для
вывода цвета, будем называть - холст.
1. При открытии приложения кнопка позиционируется по центру окна.
2. Окно приложения поддерживает изменение размеров.
3. Окно приложения поддерживает сворачивание на панель задач.
4. Окно приложения поддерживает разворачивание на весь экран.
5. Расстояние от всех элементов управления (кроме "холста") до правого края окна
должно быть постоянным.
6. Расстояния от "холста" до левого, верхнего и нижнего краёв окна должны быть
постоянными.
7. При наведении курсора мыши на "холст" должна появляться всплывающая
подсказка, содержащая шестнадцатеричный код цвета.
8. При изменении позиций ползунков, цвет "холста" должен изменяться на цвет,
соответствующий позициям ползунков.
9. При изменении позиций ползунков, цвет, соответствующий их позициям, должен
быть записан в буфер обмена в виде строки, содержащей его шестнадцатеричный
код.
Взаимодействие с буфером обмена
Для взаимодействия с буфером обмена можно использовать статические методы
класса Clipboard из пространства имён System.Windows.Forms.
Для записи строки в буфер обмена следует вызвать метод SetText().
Clipboard.SetText("#CDCDCD");
Для получения данных из буфера обмена можно пользоваться методов GetText() того же
класса.
string color = Clipboard.GetText();
Оба метода имеют перегруженные варианты, принимающие дополнительный параметр
типа TextDataFormat. Тип описан в пространстве имён System.Windows.Forms следующим
образом.
<code>
Как можно видеть из описания типа данных, TextDataFormat - это перечисление,
определяющее, в каком из распространённых форматов описан текст.