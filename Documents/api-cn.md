## PZ.RxAvalonia API 文档

### ComponentBase
组件基类，继承自 Avalonia 的 Decorator。
> 虚方法和抽象方法
+ `override void Build()` 返回填充到Content的Control
+ `override void BuildStyles()` 返回当前Component的Styles
+ `override void OnCreated()` 在Build之前执行,用于执行初始化之前需要的操作
+ `override void OnAfterInitialized()` 初始化之后执行
+ `override IEnumerable<IDisposable> WhenActivate()` 在组件Load时执行,用于订阅事件等操作,返回的IDisposable会在组件UnLoad时释放
> Resource相关
+ `object? StaticResource<T>(object key, IResourceHost? anchor = null)` 静态获取Resource,静态获取的Resource不会随资源变更而变更
+ `T StaticResource<T>(object key, Func<object?, T> converter, IResourceHost? anchor = null)` 静态获取Resource并转换为对应类型
+ `IBrush StaticColor(object key, IResourceHost? anchor = null)` 静态获取Resource并转换IBrush,失败时返回Transparent
+ `IObservable<T> DynamicResource<T>(object key, Func<object?, T> converter, IResourceHost? anchor = null)` 动态获取Resource,资源变更时会发出新值
+ `IObservable<IBrush> DynamicColor(object key, IResourceHost? anchor = null)` 动态获取Resource并转换为IBrush,资源变更时会发出新值,失败时返回Transparent
> Data Validation相关
+ `void RegisterDataValidation()` 注册当前组件的数据验证功能,需要在Build前调用(例:`OnCreated()`)
+ `bool CheckDataValidation()` 验证当前组件内的数据
