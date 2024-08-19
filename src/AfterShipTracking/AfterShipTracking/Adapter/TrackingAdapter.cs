/*
 * This code was auto generated by AfterShip SDK Generator.
 * Do not edit the class manually.
 */
namespace AfterShipTracking
{
    /// <summary>
    /// Tracking adapter for legacy object convert to new model object
    /// </summary>
    public class CreateTrackingAdapter : IAdapter<Tracking, CreateTrackingResponse>
    {
        public Tracking Adapt(CreateTrackingResponse source)
        {
            return source.Tracking;
        }
    }

    /// <summary>
    /// Tracking adapter for legacy object convert to new model object
    /// </summary>
    public class RetrackTrackingByIdAdapter
        : IAdapter<PartialUpdateTracking, RetrackTrackingByIdResponse>
    {
        public PartialUpdateTracking Adapt(RetrackTrackingByIdResponse source)
        {
            return source.Tracking;
        }
    }

    /// <summary>
    /// Tracking adapter for legacy object convert to new model object
    /// </summary>
    public class MarkTrackingCompletedBySlugTrackingNumberAdapter
        : IAdapter<Tracking, MarkTrackingCompletedBySlugTrackingNumberResponse>
    {
        public Tracking Adapt(MarkTrackingCompletedBySlugTrackingNumberResponse source)
        {
            return source.Tracking;
        }
    }

    /// <summary>
    /// Tracking list data adapter for legacy object convert to new model object
    /// </summary>
    public class GetTrackingsAdapter
        : IAdapter<GetTrackingsResponseTrackingListData, GetTrackingsResponse>
    {
        public GetTrackingsResponseTrackingListData Adapt(GetTrackingsResponse source)
        {
            GetTrackingsResponseTrackingListData data = new GetTrackingsResponseTrackingListData();
            data.Trackings = source.Trackings;
            data.Pagination = new PaginationPage(source.Page, source.Limit, source.Count);
            return data;
        }
    }

    /// <summary>
    /// Tracking adapter for legacy object convert to new model object
    /// </summary>
    public class GetTrackingByIdAdapter : IAdapter<Tracking, GetTrackingByIdResponse>
    {
        public Tracking Adapt(GetTrackingByIdResponse source)
        {
            return source.Tracking;
        }
    }

    /// <summary>
    /// Tracking adapter for legacy object convert to new model object
    /// </summary>
    public class UpdateTrackingByIdAdapter : IAdapter<Tracking, UpdateTrackingByIdResponse>
    {
        public Tracking Adapt(UpdateTrackingByIdResponse source)
        {
            return source.Tracking;
        }
    }

    /// <summary>
    /// Tracking adapter for legacy object convert to new model object
    /// </summary>
    public class DeleteTrackingByIdAdapter
        : IAdapter<PartialDeleteTracking, DeleteTrackingByIdResponse>
    {
        public PartialDeleteTracking Adapt(DeleteTrackingByIdResponse source)
        {
            return source.Tracking;
        }
    }

    /// <summary>
    /// Tracking adapter for legacy object convert to new model object
    /// </summary>
    public class GetTrackingBySlugTrackingNumberAdapter
        : IAdapter<Tracking, GetTrackingBySlugTrackingNumberResponse>
    {
        public Tracking Adapt(GetTrackingBySlugTrackingNumberResponse source)
        {
            return source.Tracking;
        }
    }

    /// <summary>
    /// Tracking adapter for legacy object convert to new model object
    /// </summary>
    public class UpdateTrackingBySlugTrackingNumberAdapter
        : IAdapter<Tracking, UpdateTrackingBySlugTrackingNumberResponse>
    {
        public Tracking Adapt(UpdateTrackingBySlugTrackingNumberResponse source)
        {
            return source.Tracking;
        }
    }

    /// <summary>
    /// Tracking adapter for legacy object convert to new model object
    /// </summary>
    public class MarkTrackingCompletedByIdAdapter
        : IAdapter<Tracking, MarkTrackingCompletedByIdResponse>
    {
        public Tracking Adapt(MarkTrackingCompletedByIdResponse source)
        {
            return source.Tracking;
        }
    }

    /// <summary>
    /// Tracking adapter for legacy object convert to new model object
    /// </summary>
    public class DeleteTrackingBySlugTrackingNumberAdapter
        : IAdapter<PartialDeleteTracking, DeleteTrackingBySlugTrackingNumberResponse>
    {
        public PartialDeleteTracking Adapt(DeleteTrackingBySlugTrackingNumberResponse source)
        {
            return source.Tracking;
        }
    }

    /// <summary>
    /// Tracking adapter for legacy object convert to new model object
    /// </summary>
    public class RetrackTrackingBySlugTrackingNumberAdapter
        : IAdapter<PartialUpdateTracking, RetrackTrackingBySlugTrackingNumberResponse>
    {
        public PartialUpdateTracking Adapt(RetrackTrackingBySlugTrackingNumberResponse source)
        {
            return source.Tracking;
        }
    }
}
