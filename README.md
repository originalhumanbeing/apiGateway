# API Gateway - Ocelot

### ocelot.json 통해 config
1. GlobalConfiguration을 통해 Ocelot이 바라 볼 BaseUrl을 정의함
2. ReRoutes 배열로 원하는 만큼 리다이렉트할 Url을 설정할 수 있음. 
  - DownStream paths는 마이크로 서비스의 실제 Url.
  - Upstream paths는 사용자들이 API Gateway를 통해서 마이크로 서비스로 접근할 수 있는 Url.
3. 변수명을 정하여 각각의 api를 한 번에 받는 와일드카드 리다이렉션도 가능함.
  - 이번 프로젝트에서는 {catchAll}이라는 변수명을 사용하여 catalog-api로 들어오는 모든 요청 트래픽은 7001 포트의 api로,
   orders-api로 들어오는 모든 요청 트래픽은 7002 포트의 api로 리다이렉트함
