# Generated by Django 5.1.1 on 2024-09-05 20:22

import django.db.models.manager
from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='UniversityClasses',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('title', models.CharField(blank=True, default='', max_length=60)),
                ('Course_number', models.IntegerField(blank=True, default='')),
                ('Instructor_name', models.CharField(blank=True, default='', max_length=60)),
                ('duration', models.FloatField(blank=True, default=None, null=True)),
            ],
            options={
                'verbose_name_plural': 'University Classes',
            },
            managers=[
                ('object', django.db.models.manager.Manager()),
            ],
        ),
    ]
