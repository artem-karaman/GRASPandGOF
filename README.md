# GRASPandGOF

## GRASP - General Responsibility Assignment Software Patterns

[Шаблоны разработки ПО. Шаблоны GRASP](https://www.youtube.com/watch?v=8wRQ92Hg2bY&t=3s)

- [x] [Information Expert](#information-expert)
- [x] [Creator](#creator)
- [x] [Controller](#controller)
- [ ] Low coupling
- [ ] High cohesion
- [ ] Polymorphism
- [ ] Pure Fabrication
- [ ] Indirection
- [ ] Protected Variations

# Information expert

### Проблема:
В системе должна аккумулироваться, расчитываться и т.п. необходимая информация.

### Решение:
- Назначить обязанности аккумуляции информации, расчёта и т.п. некоемому классу (информационному эксперту), обладающему необходимой информацией.
### Рекомендации:
- Информационным экспертом может быть не один класс, а несколько.

# Creator (создатель экземпляров класса)

### Проблема:
- Кто должен отвечать за создание экземпляров класса

### Решение:
- Назначить классу B обязанности создавать объекты другого класса А

### Рекомендации:
- Логично использовать паттерн, если класс В содержит, агрегирует, активно использует и т.п. объекты класса А.

# Controller

### Проблема:
- Кто должен отвечать за обработку входных системных событий?

### Решение:
- Обязанности по обработке системных сообщений делегируются специальному классу. Котроллер - это объект, который отвечает за обработку системных событий и не относится к интерфейсу пользователя. Контроллер определяет методы для выполнения системных операций.

### Рекомендации:
- Для различных прецедентов логично использовать разные контроллеры (контроллеры прецедентов) - контроллеры не должны быть перегружены. Внешний контроллер предоставляет всю систему целиком, его можно использовать, если он будет не слишком перегруженным (т.е. если существует лишь несколько системных событий)
