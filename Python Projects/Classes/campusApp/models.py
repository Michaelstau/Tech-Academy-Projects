from django.db import models

class UniversityCampus(models.Model):
  """ Setting up a model with three attributes, model manager, and nice looking plural name. """
  campus_name = models.CharField(max_length=90, default="", blank=True, null=False)
  state = models.CharField(max_length=2, default="", blank=True, null=False)
  campus_id = models.IntegerField(default="", blank=True, null=False)

  object = models.Manager()

  class Meta:
    verbose_name_plural = "University Campus"
