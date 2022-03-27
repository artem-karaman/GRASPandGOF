# Builder

### Суть паттерна

- **Строитель** - это порождающий паттерн проектирования, который позволяет создавать сложные объекты пошагово. Строитель даёт возможность использовать один и тот же код строительства для получения разных представлений объектов.

### Проблема
- Представьте сложный объект, требующий кропотливой пошаговой инициализации множества полей и вложенных объектов. Код инициализации таких объектов обычно спрятан внутри монструозного конструктора с десятком параметров. Либо ещё хуже — распылён по всему клиентскому коду.

### Решение
- Паттерн Строитель предлагает вынести конструирование объекта за пределы его собственного класса, поручив это дело отдельным объектам, называемым строителями.

### Струтура паттерна
- [Builder Stucture - Code](https://github.com/artem-karaman/Unity-Design-Pattern/blob/master/Assets/Creational%20Patterns/Builder%20Pattern/Structure/BuilderStructure.cs)
- [Demo code](https://github.com/artem-karaman/GRASPandGOF/tree/master/GOF/Creational%20design%20patterns/Builder/source/Builder)
- [WebGL build with demo](https://artem-karaman.github.io/GRASPandGOF/Builder)

<div id="diagram" align="center">
  
  
![Builder drawio](https://user-images.githubusercontent.com/19500536/160257801-b5265909-a664-4db7-b8fd-8eed1eb4ee68.svg)
  
  
</div>
### Подробнее 
TODO
