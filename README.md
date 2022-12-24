CRM система.

<<Цель проекта>>

Помочь компании #SkillProfi оптимизировать выполнение рутинных задач.

<<Проблема>>

Приём звонков, ведение базы данных и прочие рутинные задачи отнимают много времени, поэтому неплохо бы оптимизировать эти процессы. Так как проект молодой, основатели посчитали, что нанимать дополнительных сотрудников в штат нерентабельно, поэтому пока что заявки обрабатывает Арамис. Но это требует личного присутствия в офисе и отнимает время, которое один из основателей мог бы потратить на расширение бизнеса. Создание цифровой системы для управления базой решило бы эту проблему.

<<Задача>>

Чтобы упростить работу с клиентами, основатели #SkillProfi сделали лендинг для приема заявок. Теперь им нужна CRM, в которой хранятся эти заявки и вся история переговоров с клиентами. Они просят создать CRM, которая будет решать задачи проекта.

К тому же бизнес молодой, поэтому ежедневно Атос придумывает новые услуги, которые они могли бы продавать. Их надо показывать на лендинге, но денег на отдельного специалиста тоже нет. Поэтому в CRM должно быть реализовано не только ведение клиентов, но и возможность редактировать лендинг. Портос смотрит в сторону продвижения бизнеса через мессенджеры, поэтому вторым шагом работы над ней будет разработка Telegram бота.

<<Проект состоит из 3 составляющих:>>

Клиентская часть - представляет из себя 3 составляющих.
web приложение,
приложение для рабочего стола (WPF приложение),
Telegram бот. Бот имеет права “Гость”, бот с помощью Web API запрашивает информацию о продуктах и выводит информацию, а также реализована возможность оставлять заявки на услуги.
Web API сервис, позволяет взаимодействовать с базой данных.
База данных - для взаимодействия с базой данных использовано Entity Framework Core.
У клиентской части реализована авторизация, а также реализовано разграничение ролей:

1. Гость - имеет право на просмотр страниц с проектом и оставлять заявки на услуги;
2. Администратор - имеет право управлять всем контентом, который видит пользователь с ролью “Гость”:
	- Главная страница.
	- Страница Услуг.
	- Страница Проекты.
	- Страница Блог.
	- Видит пользователей.
	- Изменение внешнего вида страницы подачи заявок.

<<Данные для настройки реализованных частей дипломного проекта>>

<<Проект IT_Consulting_CRM_Web (веб сайт):>>

Для сборки проекта требуется подключить к проекту NuGet пакеты:
Bootstrap.v3.Datetimepicker версии 4.17.49;
Newtonsoft.Json версии 13.0.1;
В файле приложения appsettings.json
в секции «ConnectionStrings» в строке «UserConnection» указывается строка подключения к БД MS SQL Server, в которой содержатся данные пользователей для авторизации;
в секции "ConnectionServer" – в строке «DefaultConnection» содержится url подключения к веб серверу SkillProfi_WebAPI.
При запуске, если в БД отсутствуют пользователи, производится добавление пользователя логин = "admin" пароль = "admin", требуется для авторизации и настройки списка пользователей.

<<Проект IT_Consulting_CRM_API (Web API сервис):>>

Для работы проекта требуется наличие установленного MS SQL Server
Для сборки проекта требуется подключить к проекту NuGet пакеты:
Microsoft.AspNetCore.Authentication.JwtBearer версии 6.0.10;
Microsoft.AspNetCore.Identity.EntityFrameworkCore версии 6.0.10;
Microsoft.EntityFrameworkCore.SqlServer версии 6.0.10;
Microsoft.EntityFrameworkCore.Tools версии 6.0.10;
Microsoft.IdentityModel.Tokens версии 6.24.0;
Microsoft.VisualStudio.Web.CodeGeneration.Design версии 6.0.10;
Swashbuckle.AspNetCore версии 6.4.0;
System.IdentityModel.Tokens.Jwt версии 6.24.0;
Telegram.Bot версии 18.0.0;
В файле приложения appsettings.json
в секции «ConnectionStrings» - в строке «DataConnection» указывается строка подключения к БД MS SQL Server, в которой содержатся данные о проектах, услугах, блоге, контактных данных и сохраненными данными входящих заявок;

<<Проект Desktop_App (приложение для рабочего стола):>>

Для сборки проекта требуется подключить к проекту NuGet пакеты:
Microsoft.Xaml.Behaviors.Wpf версии 1.1.39;
System.Drawing.Common версии 7.0.0;
Newtonsoft.Json версии 13.0.1;

<<Проект Bot (Telegram бот):>>

Для сборки проекта требуется подключить к проекту NuGet пакеты:
Telegram.Bot версии 18.0.0-alpha.3;

<<Данные для запуска проекта>>

Проект реализован на Visual Studio Community 2022 - можно бесплатно скачать и установить с официального сайта Microsoft.

Необходимо скачать данные по ссылке https://github.com/1R1SH1/IT_Consulting_CRM_API.git

<<Запуск приложения "IT_Consulting_CRM_API">>

1) Запускаем Visual Studio

- Выбираем "Открыть проект или решение"
- В открывшемся окне находим и выбираем папку IT_Consulting_CRM_API и открываем ее
- Далее выбираем IT_Consulting_CRM_API.sln и нажимаем открыть

2) Установка пакетов NuGet
- В открывшемся Visual Studio находим "Обозреватель решений"
- Правой кнопкой нажимаем на Решение "IT_Consulting_CRM_API" и нажимаем Управление пакетами NuGet для решения...
- В открывшемся окне нажимаем на "Обзор"
- В поле поиск пишем название необходимого пакета которые описаны выше в разделе <<Проект IT_Consulting_CRM_API (Web API сервис):>>
- Поочередно устанавливаем все необходимые пакеты в тчоности с такой же версией как написано
- По завершении установки всех пакетов в Верхней панели нажимаем на "Сборка" и далее нажимаем "Собрать решение"
- Находим окно "Список ошибок" и убеждаемся, что нет ошибок с Красной пометкой

3) Установка Миграции и обновление Базы данных
- Находим и нажимаем на кнопку "Средства" там же находим и выбираем "Диспетчер пакетов NuGet" в выпадающей панели выбираем и нажимаем "Консоль диспетчера пакетов"
- В открывшемся поле "Консоль диспетчера пакетов" набираем команды: 1) add-migration "любое название" и жмём Enter
                                                                    2) update-database и жмём Enter

4) Запуск приложения
- В верхней панели находим зелёную треугольную кнопку, справа этой кнопки есть маленький треугольничек указывающий вниз для выбора опции запуска, находим ее и жмём
- В выпадающем меню зелёной треугольной кнопки выбираем опцию запуска соответствующей названию проекта, а именно IT_Consulting_CRM_API
- Запускаем приложение нажав на зелёную треугольную кнопку
- Запустится ваш браузер, на этом запуск приложения IT_Consulting_CRM_API завершён.

<<Запуск приложения "IT_Consulting_CRM_Web">>

1) Запускаем Visual Studio

- Выбираем "Открыть проект или решение"
- В открывшемся окне находим и выбираем папку IT_Consulting_CRM_Web и открываем ее
- Далее выбираем IT_Consulting_CRM_Web.sln и нажимаем открыть

2) Установка пакетов NuGet
- В открывшемся Visual Studio находим "Обозреватель решений"
- Правой кнопкой нажимаем на Решение "IT_Consulting_CRM_Web" и нажимаем Управление пакетами NuGet для решения...
- В открывшемся окне нажимаем на "Обзор"
- В поле поиск пишем название необходимого пакета которые описаны выше в разделе <<Проект IT_Consulting_CRM_Web (веб сайт):>>
- Поочередно устанавливаем все необходимые пакеты в тчоности с такой же версией как написано
- По завершении установки всех пакетов в Верхней панели нажимаем на "Сборка" и далее нажимаем "Собрать решение"
- Находим окно "Список ошибок" и убеждаемся, что нет ошибок с Красной пометкой

3) Запуск приложения
- В верхней панели находим зелёную треугольную кнопку, справа этой кнопки есть маленький треугольничек указывающий вниз для выбора опции запуска, находим ее и жмём
- В выпадающем меню зелёной треугольной кнопки выбираем опцию запуска IIS Express
- Запускаем приложение нажав на зелёную треугольную кнопку
- Запустится ваш браузер, на этом запуск приложения IT_Consulting_CRM_Web завершён.

<<Запуск приложения "Desktop_App">>

1) Запускаем Visual Studio

- Выбираем "Открыть проект или решение"
- В открывшемся окне находим и выбираем папку Desktop_App и открываем ее
- Далее выбираем Desktop_App.sln и нажимаем открыть

2) Установка пакетов NuGet
- В открывшемся Visual Studio находим "Обозреватель решений"
- Правой кнопкой нажимаем на Решение "Desktop_App" и нажимаем Управление пакетами NuGet для решения...
- В открывшемся окне нажимаем на "Обзор"
- В поле поиск пишем название необходимого пакета которые описаны выше в разделе <<Проект Desktop_App (приложение для рабочего стола):>>
- Поочередно устанавливаем все необходимые пакеты в тчоности с такой же версией как написано
- По завершении установки всех пакетов в Верхней панели нажимаем на "Сборка" и далее нажимаем "Собрать решение"
- Находим окно "Список ошибок" и убеждаемся, что нет ошибок с Красной пометкой

3) Запуск приложения
- В верхней панели находим зелёную треугольную кнопку, справа этой кнопки есть маленький треугольничек указывающий вниз для выбора опции запуска, находим ее и жмём
- В выпадающем меню зелёной треугольной кнопки выбираем опцию запуска соответствующей названию проекта, а именно Desktop_App
- Запускаем приложение нажав на зелёную треугольную кнопку
- Запустится приложение для рабочего стола, на этом запуск приложения Desktop_App завершён.

<<Запуск приложения "Bot">>

1) Запускаем Visual Studio

- Выбираем "Открыть проект или решение"
- В открывшемся окне находим и выбираем папку Bot и открываем ее
- Далее выбираем Bot.sln и нажимаем открыть

2) Установка пакетов NuGet
- В открывшемся Visual Studio находим "Обозреватель решений"
- Правой кнопкой нажимаем на Решение "Bot" и нажимаем Управление пакетами NuGet для решения...
- В открывшемся окне нажимаем на "Обзор"
- В поле поиск пишем название необходимого пакета которые описаны выше в разделе <<Проект Bot (Telegram бот):>>
- Поочередно устанавливаем все необходимые пакеты в тчоности с такой же версией как написано
- По завершении установки всех пакетов в Верхней панели нажимаем на "Сборка" и далее нажимаем "Собрать решение"
- Находим окно "Список ошибок" и убеждаемся, что нет ошибок с Красной пометкой

3) Запуск приложения
- В верхней панели находим зелёную треугольную кнопку, справа этой кнопки есть маленький треугольничек указывающий вниз для выбора опции запуска, находим ее и жмём
- В выпадающем меню зелёной треугольной кнопки выбираем опцию запуска соответствующей названию проекта, а именно Bot
- Запускаем приложение нажав на зелёную треугольную кнопку
- Запустится консольное приложение для Телеграм Бота, на этом запуск приложения Bot завершён.
