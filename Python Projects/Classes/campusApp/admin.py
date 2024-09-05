from django.contrib import admin
from .models import UniversityCampus

#importing, and then registering our UniversityCampus model to the admin page
admin.site.register(UniversityCampus)
