public class Samurai : Human{
    Samurai.health = 200;
    private static List<WeakReference> instances = new List<WeakReference>();

    public void death_blow(object obj){
        if (obj.health < 50){
            obj.health = 0;
        } 
    }
    public void meditate () {
        Samurai.health = 200;
    }
    //optional
    public Samurai(){
        instances.Add(new WeakReference(this));
    }
    public static int how_many (){
        List<MyClass> realInstances = new List<MyClass>();
        List<WeakReference> toDelete = new List<WeakReference>();
        foreach(WeakReference reference in instances){
            if(reference.IsAlive){
                realInstances.Add((MyClass)reference.Target);
            }
            else {
                toDelete.Add(reference);
            }
        }
        foreach(WeakReference reference in toDelete) instances.Remove(reference);
        return realInstances;
        }
}