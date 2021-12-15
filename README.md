# Школа онлайн-обучения

***

## Содержание
[Введение](#introduction)


[1 Описание предметной области](#domainDescription)

1.1 [Проблематика](#проблематика)

1.2 [Цели и задачи](#цели_и_задачи)

[2 Сравнительный анализ](#analyse)

[3 Разработка системы](#develope) 

3.1 [Этап проектирования](#проектирование)

3.2 [Этап реализации](#реализация)

[4 Проверка и тестирование системы](#testing) 

[Заключение](#conclusion)  

[Список использованных источников](#bibliography) 

<a name="introduction"/>

***

## Введение

Практическая работа направлена на получение опыта в программировании на языке C#. Язык программирования C# в данный момент
является одним из самых распространенных [1] и часто используемых объектно-ориентированных языков, на котором разрабатывается огромное колиичество приложений.
Необходимо создать веб-приложение, которое связано с информационной системой онлайн обучения. 
Развитие информационных технологий приводит к автоматизации многих процессов, которые происходят вокруг ежедневно. Огромное количество систем и приложений, разработанных человеком, помогают нам во многих аспектах современной жизни , для многих людей, они практически стали проводниками в мир информационных технологий.
Многие люди, особенно старшие поколения, относились довольно скептически к онлайн обучению, по большей части из-за недоверия к новым технологиям. Однако, когда в 2019 году
началось распространение коронавируса, формат дистанционного обучение стал неотъемлемой мерой безопасности, и им пришлось принять эту новинку. Стоит также упомянуть, что 
формат онлайн обучения очень удобен и позволяет учиться людям, которые по тем или иным причинам не могут посещать учебные заведения.

<a name="domainDescription"/>

***

## 1 Описание предметной области

Выбранная предметная область - дистанционное обучение. Информационная система в данной предметной области включает в себя следующие разделы: "Обучающиеся","Преподаватели",
"Завуч","Технические работники". Первое и наиболее важное это функционирование обучающихся. Пользователь входит на сайт, далее ему необходимо подать заявку на поступление
в онлайн-школу, либо если он уже является учеником, он может оценить работу сервиса и школы в целом. При подаче заявки, ею занимается система по обработке заявок,которую 
регулируют технические работники, они же занимаются поддержкой функционирования сайта и вносят учеников в базу. Обучение учеников основано на прохождении курсов.
Эти самые курсы создает завуч, которому прежде всего необходимо разработать учебный план. После разработки учебного плана, завучу необходимо выбрать преподавателей для 
обучения учеников данному курсу. Для этого завуч обращается к преподавательскому составу, в котором все преподаватели распределены по специальностям. После того , как завуч 
проделал все вышеперечисленные действия, он добавляет учеников к курсу. Одну из главных ролей в обучении играют преподаватели, которые при добавлении в курс , занимаются непосредственным обучением и при необходимости оснащением учеников допольнительным учебным материалом.


***
## 1.1 Проблематика <a name="проблематика"></a>

 В настоящее время,несмотря на то что в сфере онлайн образования отсутствуют явные лидеры, которые могли бы задать монопольные цены, цены на прохождение курсов все равно очень   высокие. Огромное количество людей , несмотря на удобство прохождения онлайн-курсов , выбирают в пользу привычных курсов , которые зачастую стоят дешевле , а некоторые и вовсе являются бесплатными.
 Еще одной явной проблемой онлайн-школ является то, что некоторые преподаватели сами не имеют должного образования или не владеют достаточно развитыми навыками спикера , чтобы донести всю информацию до учеников таким образом чтобы они усвоили материал.
 
***
## 1.2 Цели и задачи <a name="цели_и_задачи"></a>

 Целью данной работы является создание полностью бесплатной онлайн-школы и улучшение качества онлайн образования в целом.
 
 Для этого необходимо реализовать следующие пункты:
1) Найти "точки соприкосновения" с рекламодателями.(Как реализовать рекламу в рамках онлайн-курса(нативная реклама, баннеры и т.д))
2) Расположить рекламу таким образом, чтобы она никак не мешала обучение и не "бросалась в глаза".
3) Ужесточить контроль набора в штат сотрудников с помощью входных тестов и пробных периодов работы.

***
## 2 Сравнительный анализ <a name="analyse"/>

В настоящее время существует огромное количество онлайн-школ , в которых обучаются миллионы людей. Одной из наиболее[2] популярных онлайн-школ является школа онлайн-образования
Skillbox,основанная в 2016 году. На данный момент эта школа насчитывается более 300 тысяч пользователей, что говорит о высоком спросе на онлайн-образование.
Более того, данная школа сотрудничает с многими предприятиями, что помогает трудоустроить учеников, проходящих курсы на Skillbox'e.Также стоит отметить, что 
на данной платформе существуют не только обычные курсы, но также и программы обучения совместно с Российскими вузами , по окончании которых студент получает диплом 
государственного образца.Основной проблемой в данном контексте является цена прохождения курсов.

В качестве другого примера можно привести онлайн-курсы Лекториума. Лекториум — санкт-петербургский некоммерческий проект, занимающийся созданием учебных материалов в формате открытых онлайн-курсов, а также съёмкой и размещением видеолекций.Однако даже здесь есть платные курсы, хоть проект и обозначен как некоммерческий. А задача данного проекта реализовать полностью бесплатное обучение в онлайн формате.


<a name="develope"/>

***
## 3 Разработка системы <a name="testing"/>

Разработка системы состоит из двух этапов.Первый этап - это проектирование, в ходе этого этапа определяются цели создания, требования и желаемый результат, также на этом этапе определяют основные источники информации,их надежность и согласованность предоставляемых данных.
Вторым этапом является реализация программной части , в ходе которой результаты проектирования превращаются в готовый продукт посредством написания программного обеспечения.

***
## 3.1 Этап проектирования <a name="этап_проектирования"></a>

Разработка начинается с проектирования диаграммы вариантов использования (use-case diagram)(см. рисунок 1), где отражаются главные действующие лица данной системы : преподаватель, обучающийся, технический работник, завуч. 

<p align="center">
<img src="https://user-images.githubusercontent.com/91196381/146252782-b8f893b2-2f00-48dc-938a-c495e34fb7ac.png"></p>
<p align="center">Рисунок 1 - Use-case diagram</p> 

На основе use-case диаграммы происходит разработка диаграммы потока данных (Data Flow Diagram), на которой показаны потоки данных.(см. рисунок 2)

<p align="center">
<img src="https://user-images.githubusercontent.com/91196381/146257314-504d5755-d8ac-45df-ace6-218f70ba779d.png"></p>
<p align="center">Рисунок 2 - Data Flow Diagram</p> 

Далее создаем диаграмму Сущность-Связь (Entity-Relationship diagram)(см. рисунок 3),где отображаются хранилища и связи между ними.

<p align="center">
<img src="https://user-images.githubusercontent.com/91196381/146257949-7e7c3cc9-c37b-46d4-8bce-785908bf0163.png"></p>
<p align="center">Рисунок 3 - Entity-Relationship Diagram</p> 

## 3.2 Этап реализации <a name="реализация"></a>

На основании ER диаграммы создаем классы для каждой сущности.Ниже приведен пример создания класса Обучающийся.
Листинг 1 - Класс "Студент"
~~~csharp
namespace getone.Domains
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int Group { get; set; }

        public Student() { }

        public Student(int studentId,string fullName,string email,string phoneNumber,int group)
        {
            StudentId = studentId;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Group = group;
        }

    }
}
~~~
Листинг 2 - Класс "Преподаватель"
~~~csharp
namespace getone.Domains
{
    public class Teacher
    {
        public string FullName { get; set; }

        public string Specification { get; set; }

        public int TeacherId { get; set; }

        public Teacher() { }


        public Teacher(string fullName,string specification,int teacherId)
        {
            FullName = fullName;
            Specification = specification;
            TeacherId = teacherId;
        }

    }
}
~~~

Затем создаем хранилище , где будут храниться экземпляры классов. Листинг 3 - хранилище для класса "Обучающийся".
~~~csharp
namespace getone.Storages
{
        public class StudentStorage
        {
            private Dictionary<int, Student> Studnets { get; } = new Dictionary<int, Student>();

            public void Create(Student studnet)
            {
            Studnets.Add(studnet.StudentId, studnet);
            }

            public Student Read(int studentId)
            {
                return Studnets[studentId];
            }

            public Student Update(int studentId, Student newStudnet)
            {
                Studnets[studentId] = newStudnet;
                return Studnets[studentId];
            }

            public bool Delete(int studentId)
            {
                return Studnets.Remove(studentId);
            }
        }
}
~~~~
Листинг 4 - общее хранилище.
~~~csharp
namespace getone.Storages
{
    public static class Storage
    {
        public static readonly ApplicationJournalStorage ApplicationJournalStorage = new();
        public static  readonly CoursematerialStorage CoursematerialStorage = new();
        public static  readonly CourseStorage CourseStorage = new();
        public static  readonly EducationalPlanStorage EducationalPlanStorage = new();
        public static  readonly FeedbackJournalStorage FeedbackJournalStorage = new();
        public static  readonly GroupStorage GroupStorage = new();
        public static  readonly HeadTeacherStorage HeadTeacherStorage = new();
        public static  readonly ScheduleStorage ScheduleStorage = new();
        public static readonly StudentStorage StudentStorage = new();
        public static readonly TeacherStorage TeachersStorage = new();
        public static readonly TechnicianStorage TechiciansStorage = new();

    }
}
~~~

Далее создадим контроллер для каждой сущности и добавим набор web-методов,включая 4 базисные операции CRUD(create,delete,update,delete).Пример контроллера для класса "Обучающийся" - Листинг 5.
~~~csharp
namespace getone.Controllers
{
    [ApiController]
    [Route("/Student")]
    public class StudentController : ControllerBase
    {

        [HttpPost("Filingapplication")]
        public string Filingapplication(string str)
        {
            return str; // Подача заявок на поступление
        }
        [HttpPost("Serviceevaluation")]
        public string Serviceevaluation(string str)
        {
            return str;// Оценка работы сервиса
        }
        [HttpPost]
        public Student Create(Student student)
        {
            Storage.StudentStorage.Create(student);
            return student;
        }

        [HttpGet]
        public Student Read(int studentId)
        {
            return Storage.StudentStorage.Read(studentId);
        }

        [HttpPut]
        public Student Update(int studentId, Student newStudent)
        {
            return Storage.StudentStorage.Update(studentId, newStudent);
        }

        [HttpDelete]
        public bool Delete(int studentId)
        {
            return Storage.StudentStorage.Delete(studentId);
        }
    }
}
~~~
## 4 Проверка и тестирование системы
После запуска программы открывается страница Swagger UI со списком сущностей и возможных операций.(см. рисунок 4)
<p align="center">
<img src="https://user-images.githubusercontent.com/91196381/146263517-5f9d6d5e-29c1-4aeb-8a4d-123f70e7f6d7.png"></p>
<p align="center">Рисунок 4 - Cтраница Swagger UI</p> 

Далее на странице можем увидеть список доступных методов CRUD для сущности "обучающийся".(см. рисунок 5)
<p align="center">
<img src="https://user-images.githubusercontent.com/91196381/146263983-8a93491b-7250-4287-ad17-de0d23f87c65.png"></p>
<p align="center">Рисунок 5 - Методы CRUD</p> 

Проверка метода Create(позволяет добавить новую запись).(см. рисунок 6)
<p align="center">
<img src="https://user-images.githubusercontent.com/91196381/146269927-15c6e250-5a43-45cd-9088-178671897f91.png"></p>
<p align="center">Рисунок 6 - Метод Create</p> 

Проверка метода Read(позволяет считывать уже созданные записи)(см. рисунок 7,8)
<p align="center">
<img src="https://user-images.githubusercontent.com/91196381/146266529-47e1fab6-b920-46c1-a6e4-b0568d97631f.png"></p>
<p align="center">Рисунок 7 - Метод Read(окно ввода)</p> 
<p align="center">
<img src="https://user-images.githubusercontent.com/91196381/146270139-2cc012f3-c2dc-4b06-8cb3-f46681d1943d.png"></p>
<p align="center">Рисунок 8 - Метод Read(окно значений)</p> 

Проверка метода Update(позволяет изменить уже записанные данные)(см. рисунок 9,10)
<p align="center">
<img src="https://user-images.githubusercontent.com/91196381/146270852-d438a587-8657-483b-a658-96ea379b3f30.png"></p>
<p align="center">Рисунок 9 - Метод Update(ввод новых данных)</p> 
<p align="center">
<img src="https://user-images.githubusercontent.com/91196381/146271049-dada03ff-602a-44f6-8960-b4c576bb1096.png"></p>
<p align="center">Рисунок 10 - Метод Update(обновленная информация)</p> 
Далее проверяем записалась ли информация с помощью метода Read(см. рисунок 11)
<p align="center">
<img src="https://user-images.githubusercontent.com/91196381/146271344-65b4fae1-ea30-4c42-ad62-e5989c6f9f43.png"></p>
<p align="center">Рисунок 11 - Проверка значений</p> 
<a name="conclusion"/>

## Заключение

<a name="bibliography"/>

## Список использованных источников

<a name="sourse_1">
  1.Рейтинг популярности языков программирования. tiobe.com [Электронный ресурс]. - Режим доступа: https://www.tiobe.com/tiobe-index/#:~:text=5-,C#,-6.06% , свободный (дата обращения: 15.12.2021)
 
 2.Рейтинг популярности платформ онлайн обучения. br-analytics.ru [Электронный ресурс]. - Режим доступа: https://br-analytics.ru/blog/top-20-education-2020-2021/ , свободный (дата обращения 15.12.2021)
 
- 
