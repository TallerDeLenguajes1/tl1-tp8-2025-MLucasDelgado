[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/yWedu6XH)

# 🧮 Proyecto .NET Console: Calculadora con Historial + Gestor de Tareas (ToDo)

Este repositorio contiene dos proyectos de consola en C#:

1. **📌 CalculadoraHistorial**: una calculadora básica que permite realizar operaciones matemáticas (+, -, ×, ÷) y guarda un historial de todas las operaciones realizadas.
2. **📋 ToDo**: una aplicación de gestión de tareas que permite crear tareas, buscarlas, marcarlas como realizadas y visualizar el listado completo.

---

## 🧮 Calculadora con Historial

### 🔧 Funcionalidades

- Sumar, restar, multiplicar y dividir números.
- Prevenir errores por división entre cero.
- Limpiar el resultado actual.
- Guardar un historial completo de las operaciones realizadas.
- Mostrar dicho historial con detalle.

### ▶️ Ejemplo de uso

```
Ingrese un número inicial: 20
1 - Sumar
2 - Restar
...
Elegir una opción: 1
Ingrese un valor: 5

Resultado actual: 25

Ver historial:
20 + 5 = 25
```

---

## 📋 Proyecto ToDo - Gestor de Tareas

### 🔧 Funcionalidades

- Crear una cantidad personalizada de tareas ingresadas por el usuario.
- Asignar descripción y duración a cada tarea.
- Validar que la duración esté entre 10 y 100.
- Marcar tareas como realizadas (se mueven a otra lista).
- Buscar tareas pendientes por descripción.
- Mostrar las tareas pendientes y realizadas.

### ▶️ Ejemplo de uso

```
¿Cuántas tareas desea ingresar?: 2
Ingrese la descripción: estudiar
Ingrese duración: 45

¿Desea marcar esta tarea como realizada? (s/n): s

Se movió a tareas realizadas.
```

---

## 🛠️ Tecnologías usadas

- Lenguaje: **C#**
- Plataforma: **.NET Console Application**
- IDE recomendado: **Visual Studio / VS Code**
- Control de versiones: **Git**

---

## 🚀 Cómo ejecutar cada proyecto

Desde la raíz del repositorio:

### CalculadoraHistorial

```bash
cd CalculadoraHistorial
dotnet run
```

### ToDo

```bash
cd ToDo
dotnet run
```

---
