from django.urls import path
from . import views

""" setting up the urls we plan to be using and the corresponding functions to call from views.py """
urlpatterns = [
  path('', views.home, name='index'),
  path('create/', views.create_account, name='create'),
  path('<int:pk>/balance/', views.balance, name='balance'),
  path('transaction/', views.transaction, name='transaction')
]
