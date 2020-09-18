class InvalidDriverException : Exception {
}

class Run
{
  private Driver _driver;
  
  public void setDriver(driver)
  {
    if (!driver.isReady())
    {
      throw new InvalidDriverException("Le chauffeur est au repos!")
    }
    
    _driver = driver;
  }
}

class Main
{  
  public void addRun(Driver driver, DateTime start, Vehicle vehicle)
  {
      Run run = new Run();
      run.setDriver(driver);
      run.setVehicle(vehicle);
    
      AddToList(run);
  }
  
  public void cmdNewRun_click(...)
  {
    FRun form = new FRun();
    form.ShowDialog();
    
    try {
      addRun(form.driver, form.start, form.vehicle);
    }
    catch (InvalidDriverException exception) {
      MessageBox.Show(exception.message);
    }
    catch (Exception exception) {
      MessageBox.Show("Ya un super gros blème, tcho!");
      Exit(0);
    }
  }
}
