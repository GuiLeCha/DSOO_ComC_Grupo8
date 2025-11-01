# Proyecto Integrador – DSOO – Comisión C – Grupo 8

Este repositorio contiene el sistema del Proyecto Integrador de la materia Desarrollo de Sistemas Orientado a Objetos (DSOO).
---

## Objetivo general

El sistema permite registrar socios y no socios, gestionar las cuotas, controlar los pagos, registrar el apto físico y emitir carnets e informes.

---

## Tecnologías utilizadas

- Lenguaje: C#
- Entorno: Visual Studio 2022
- Base de datos: MySQL

---

## Estado actual

Hasta el momento el sistema incluye:
- Clases principales: Persona, Socio y NoSocio
- Registro funcional de socios
- Conexión a la base de datos
- Menú principal básico

---

## Próximos pasos

- Registro funcional de no socios
- Incorporar control de apto físico en el alta de socio y no socio
- Agregar módulo de cuotas y pagos
- Emitir carnet con opción de impresión
- Crear reportes básicos
- Ajustar la interfaz y preparar documentación final
- Realizar pruebas básicas de funcionamiento antes de la entrega final

---

## Nota final

El objetivo del proyecto no es hacer un sistema perfecto, sino demostrar que entendimos los conceptos principales de la materia y que podemos aplicarlos en un desarrollo real.
Cada avance del sistema se sube a este repositorio para mostrar el progreso del grupo en las distintas etapas del proyecto.

---

## Actualización del registro de personas (30/10/2025)

Descripción:
Se unificó el alta de socios y no socios en un solo formulario (FrmRegistrarPersona).  
Se incorporaron validaciones completas de datos, control de duplicados y apto físico obligatorio.  
Se eliminó el formulario anterior de socios, se ajustó el menú principal y se actualizó la base con las tablas persona, socios, nosocios y aptosfisicos.

Resultado:
El sistema permite registrar correctamente tanto socios como no socios, validando los datos y exigiendo la presentación del apto físico antes de guardar.

---

## Actualización: 31 de octubre de 2025

En esta actuailzación se incorporaron las funcionalidades correspondientes al módulo de pagos y la emisión del carnet de socio.

### Cambios principales
- Apertura automática del formulario de pago al registrar una persona.  
- Validación de tipo de persona (Socio / No Socio).  
- Registro de pagos con comprobante impreso.  
- Emisión automática de carnet para socios en su primer pago.  
- Integración completa con base de datos MySQL.  
- Impresión de comprobantes y carnets mediante PrintDocument.  
- Limpieza de código y comentarios ajustados al material docente.

### Pruebas realizadas
- Registro y conversión de persona (socio / no socio).  
- Inserción de pagos en tabla pago.  
- Generación de carnet (tabla carnet).  
- Comprobante de pago con vista previa de impresión.  
- Validaciones de campos y controles de conexión.  

---

