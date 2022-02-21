# GRASPandGOF

## GRASP - General Responsibility Assignment Software Patterns

[Шаблоны разработки ПО. Шаблоны GRASP](https://www.youtube.com/watch?v=8wRQ92Hg2bY&t=3s)

- [x] Information Expert
- [ ] Creator
- [ ] Controller
- [ ] Low coupling
- [ ] High cohesion
- [ ] Polymorphism
- [ ] Pure Fabrication
- [ ] Indirection
- [ ] Protected Variations

# Information expert

## Проблема:
В системе должна аккумулироваться, расчитываться и т.п. необходимая информация.

## Решение:
- Назначить обязанности аккумуляции информации, расчёта и т.п. некоемому классу (информационному эксперту), обладающему необходимой информацией.
## Рекомендации:
- Информационным экспертом может быть не один класс, а несколько.